//Extension for Unity Vector
// - Vector2
// - Vector3
// - Vector4
//Source: https://github.com/bigmarch/BigMarch/blob/master/Assets/BigMarch/Swizzle/Swizzle.cs
using UnityEngine;


namespace Extension.Vector
{
	public static class Vector2With
	{
			public static Vector2 WithX(this Vector2 v, float x) { return new Vector2(x, v.y); }
			public static Vector2 WithY(this Vector2 v, float y) { return new Vector2(v.x, y); }

			public static Vector2 WithAddX(this Vector2 v, float x) { return new Vector2(v.x + x, v.y); }
			public static Vector2 WithAddY(this Vector2 v, float y) { return new Vector2(v.x, v.y + y); }

			public static Vector2 WithSubtractX(this Vector2 v, float x) { return new Vector2(v.x - x, v.y); }
			public static Vector2 WithSubtractY(this Vector2 v, float y) { return new Vector2(v.x, v.y - y); }

			public static Vector2 WithMultiplyX(this Vector2 v, float x) { return new Vector2(v.x * x, v.y); }
			public static Vector2 WithMultiplyY(this Vector2 v, float y) { return new Vector2(v.x, v.y * y); }

			public static Vector2 WithDivideX(this Vector2 v, float x) { return new Vector2(v.x / x, v.y); }
			public static Vector2 WithDivideY(this Vector2 v, float y) { return new Vector2(v.x, v.y / y); }
	}


	public static class Vector3With
	{
			public static Vector3 WithX(this Vector3 v, float x) { return new Vector3(x, v.y, v.z); }
			public static Vector3 WithY(this Vector3 v, float y) { return new Vector3(v.x, y, v.z); }
			public static Vector3 WithZ(this Vector3 v, float z) { return new Vector3(v.x, v.y, z); }
			
			public static Vector3 WithAddX(this Vector3 v, float x) { return new Vector3(v.x + x, v.y, v.z); }
			public static Vector3 WithAddY(this Vector3 v, float y) { return new Vector3(v.x, v.y + y, v.z); }
			public static Vector3 WithAddZ(this Vector3 v, float z) { return new Vector3(v.x, v.y, v.z + z); }
			
			public static Vector3 WithSubtractX(this Vector3 v, float x) { return new Vector3(v.x - x, v.y, v.z); }
			public static Vector3 WithSubtractY(this Vector3 v, float y) { return new Vector3(v.x, v.y - y, v.z); }
			public static Vector3 WithSubtractZ(this Vector3 v, float z) { return new Vector3(v.x, v.y, v.z - z); }
			
			public static Vector3 WithMultiplyX(this Vector3 v, float x) { return new Vector3(v.x * x, v.y, v.z); }
			public static Vector3 WithMultiplyY(this Vector3 v, float y) { return new Vector3(v.x, v.y * y, v.z); }
			public static Vector3 WithMultiplyZ(this Vector3 v, float z) { return new Vector3(v.x, v.y, v.z * z); }
			
			public static Vector3 WithDivideX(this Vector3 v, float x) { return new Vector3(v.x / x, v.y, v.z); }
			public static Vector3 WithDivideY(this Vector3 v, float y) { return new Vector3(v.x, v.y / y, v.z); }
			public static Vector3 WithDivideZ(this Vector3 v, float z) { return new Vector3(v.x, v.y, v.z / z); }
	}


	public static class Vector4With
	{
			public static Vector4 WithX(this Vector4 v, float x) { return new Vector4(x, v.y, v.z, v.w); }
			public static Vector4 WithY(this Vector4 v, float y) { return new Vector4(v.x, y, v.z, v.w); }
			public static Vector4 WithZ(this Vector4 v, float z) { return new Vector4(v.x, v.y, z, v.w); }
			public static Vector4 WithW(this Vector4 v, float w) { return new Vector4(v.x, v.y, v.z, w); }
			
			public static Vector4 WithAddX(this Vector4 v, float x) { return new Vector4(v.x + x, v.y, v.z, v.w); }
			public static Vector4 WithAddY(this Vector4 v, float y) { return new Vector4(v.x, v.y + y, v.z, v.w); }
			public static Vector4 WithAddZ(this Vector4 v, float z) { return new Vector4(v.x, v.y, v.z + z, v.w); }
			public static Vector4 WithAddW(this Vector4 v, float w) { return new Vector4(v.x, v.y, v.z, v.w + w); }
			
			public static Vector4 WithSubtractX(this Vector4 v, float x) { return new Vector4(v.x - x, v.y, v.z, v.w); }
			public static Vector4 WithSubtractY(this Vector4 v, float y) { return new Vector4(v.x, v.y - y, v.z, v.w); }
			public static Vector4 WithSubtractZ(this Vector4 v, float z) { return new Vector4(v.x, v.y, v.z - z, v.w); }
			public static Vector4 WithSubtractW(this Vector4 v, float w) { return new Vector4(v.x, v.y, v.z, v.w - w); }
			
			public static Vector4 WithMultiplyX(this Vector4 v, float x) { return new Vector4(v.x * x, v.y, v.z, v.w); }
			public static Vector4 WithMultiplyY(this Vector4 v, float y) { return new Vector4(v.x, v.y * y, v.z, v.w); }
			public static Vector4 WithMultiplyZ(this Vector4 v, float z) { return new Vector4(v.x, v.y, v.z * z, v.w); }
			public static Vector4 WithMultiplyW(this Vector4 v, float w) { return new Vector4(v.x, v.y, v.z, v.w * w); }
			
			public static Vector4 WithDivideX(this Vector4 v, float x) { return new Vector4(v.x / x, v.y, v.z, v.w); }
			public static Vector4 WithDivideY(this Vector4 v, float y) { return new Vector4(v.x, v.y / y, v.z, v.w); }
			public static Vector4 WithDivideZ(this Vector4 v, float z) { return new Vector4(v.x, v.y, v.z / z, v.w); }
			public static Vector4 WithDivideW(this Vector4 v, float w) { return new Vector4(v.x, v.y, v.z, v.w / w); }
	}
}
