//Extension for Unity VectorInt
// - Vector2Int
// - Vector3Int
// - Vector4Int
//Source: https://github.com/bigmarch/BigMarch/blob/master/Assets/BigMarch/Swizzle/Swizzle.cs
using UnityEngine;


namespace Extension.VectorInt
{
	public static class Vector2IntWith
	{
			public static Vector2Int WithX(this Vector2Int v, int x) { return new Vector2Int(x, v.y); }
			public static Vector2Int WithY(this Vector2Int v, int y) { return new Vector2Int(v.x, y); }

			public static Vector2Int WithAddX(this Vector2Int v, int x) { return new Vector2Int(v.x + x, v.y); }
			public static Vector2Int WithAddY(this Vector2Int v, int y) { return new Vector2Int(v.x, v.y + y); }

			public static Vector2Int WithSubtractX(this Vector2Int v, int x) { return new Vector2Int(v.x - x, v.y); }
			public static Vector2Int WithSubtractY(this Vector2Int v, int y) { return new Vector2Int(v.x, v.y - y); }

			public static Vector2Int WithMultiplyX(this Vector2Int v, int x) { return new Vector2Int(v.x * x, v.y); }
			public static Vector2Int WithMultiplyY(this Vector2Int v, int y) { return new Vector2Int(v.x, v.y * y); }

			public static Vector2Int WithDivideX(this Vector2Int v, int x) { return new Vector2Int(v.x / x, v.y); }
			public static Vector2Int WithDivideY(this Vector2Int v, int y) { return new Vector2Int(v.x, v.y / y); }
	}


	public static class Vector3IntWith
	{
			public static Vector3Int WithX(this Vector3Int v, int x) { return new Vector3Int(x, v.y, v.z); }
			public static Vector3Int WithY(this Vector3Int v, int y) { return new Vector3Int(v.x, y, v.z); }
			public static Vector3Int WithZ(this Vector3Int v, int z) { return new Vector3Int(v.x, v.y, z); }
			
			public static Vector3Int WithAddX(this Vector3Int v, int x) { return new Vector3Int(v.x + x, v.y, v.z); }
			public static Vector3Int WithAddY(this Vector3Int v, int y) { return new Vector3Int(v.x, v.y + y, v.z); }
			public static Vector3Int WithAddZ(this Vector3Int v, int z) { return new Vector3Int(v.x, v.y, v.z + z); }
			
			public static Vector3Int WithSubtractX(this Vector3Int v, int x) { return new Vector3Int(v.x - x, v.y, v.z); }
			public static Vector3Int WithSubtractY(this Vector3Int v, int y) { return new Vector3Int(v.x, v.y - y, v.z); }
			public static Vector3Int WithSubtractZ(this Vector3Int v, int z) { return new Vector3Int(v.x, v.y, v.z - z); }
			
			public static Vector3Int WithMultiplyX(this Vector3Int v, int x) { return new Vector3Int(v.x * x, v.y, v.z); }
			public static Vector3Int WithMultiplyY(this Vector3Int v, int y) { return new Vector3Int(v.x, v.y * y, v.z); }
			public static Vector3Int WithMultiplyZ(this Vector3Int v, int z) { return new Vector3Int(v.x, v.y, v.z * z); }
			
			public static Vector3Int WithDivideX(this Vector3Int v, int x) { return new Vector3Int(v.x / x, v.y, v.z); }
			public static Vector3Int WithDivideY(this Vector3Int v, int y) { return new Vector3Int(v.x, v.y / y, v.z); }
			public static Vector3Int WithDivideZ(this Vector3Int v, int z) { return new Vector3Int(v.x, v.y, v.z / z); }
	}
}
