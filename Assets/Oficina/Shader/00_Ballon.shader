Shader "week13/00_Ballon"
{
	Properties
	{		
		_MainTex("MainImage", 2D) = "white" {}
		_SecondTex("Mask", 2D) = "White" {}
		_MaxDistance ("Max Distance", range(0.5, 10.0)) = 10.0
	}

	SubShader
	{
		Tags { "Queue"="Transparent" }		

		Pass
		{

			ZWrite Off

			Blend SrcAlpha OneMinusSrcAlpha //Key word you must to remember because it is verry important!!

			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"

			sampler2D _MainTex;
			sampler2D _SecondTex;
			float _Alpha;
			float _MaxDistance;

			struct appdata
			{
				float4 vertex : POSITION;
				float3 worldSpaceVertex : TEXCOORD1;			
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{				
				float4 vertex : SV_POSITION;
				float3 worldSpaceVertex : TEXCOORD1;
				float2 uv : TEXCOORD0;
			};
			
			v2f vert (appdata v)
			{
				v2f o;

				o.worldSpaceVertex = mul(unity_ObjectToWorld, v.vertex).xyz;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = v.uv;
				
				return o;
			}
			
			float4 frag (v2f i) : COLOR
			{
				float4 TexelColor = tex2D(_MainTex, i.uv);
				float4 SecondTexelColor = tex2D(_SecondTex, i.uv);
				float Dis = distance(_WorldSpaceCameraPos, i.worldSpaceVertex)/_MaxDistance;

				TexelColor.a = lerp(TexelColor, SecondTexelColor.r, _MaxDistance);

				return TexelColor;

			}
			ENDCG
		}
	}
}