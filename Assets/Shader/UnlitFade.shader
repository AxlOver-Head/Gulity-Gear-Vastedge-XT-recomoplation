Shader "Giraffe/UnlitFade" {
Properties {
 _Color ("Main Color", Color) = (1,1,1,1)
 _Blend ("Blend", Float) = 0
 _MainTex ("Texture 1", 2D) = "" {}
 _Texture2 ("Texture 2", 2D) = "" {}
}
SubShader { 
 Tags { "QUEUE"="Transparent" "IGNOREPROJECTOR"="true" "RenderType"="Transparent" }
 Pass {
  Tags { "QUEUE"="Transparent" "IGNOREPROJECTOR"="true" "RenderType"="Transparent" }
  ZWrite Off
  Cull Off
  Fog {
   Color (0,0,0,0)
  }
  Blend SrcAlpha One
  SetTexture [_MainTex] { combine texture, texture alpha }
  SetTexture [_Texture2] { ConstantColor (1,1,1,[_Blend]) combine texture lerp(constant) previous }
 }
}
}