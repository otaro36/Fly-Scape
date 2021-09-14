Shader"huse360/sweet"{
	Properties{

	}
	SubShader{
		Pass{
			CGPROGRAM
			   #pragma vertx vert_img
			   #pragma fragment frag
			   #include "UnityCG.cginc"

				float4 frag(v2f_img i) :COLOR{

					return float4(1,0,0,1);
				}
			ENDCG
		}
	}
}
