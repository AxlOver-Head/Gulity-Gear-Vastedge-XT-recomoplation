Shader "CriMana/GLES20Alpha" {
Properties {
 _MainTex ("Texture", 2D) = "white" {}
 Texture_y ("Texture Y", 2D) = "white" {}
 Texture_u ("Texture U", 2D) = "white" {}
 Texture_v ("Texture V", 2D) = "white" {}
 Texture_a ("Texture V", 2D) = "white" {}
}
	//DummyShaderTextExporter
	
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Lambert
#pragma target 3.0
		sampler2D _MainTex;
		struct Input
		{
			float2 uv_MainTex;
		};
		void surf(Input IN, inout SurfaceOutput o)
		{
			float4 c = tex2D(_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
		}
		ENDCG
	}
}