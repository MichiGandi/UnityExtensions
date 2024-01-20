//Extension for Unity VectorInt
// - Vector2Int
// - Vector3Int
// - Vector4Int
//Source: https://github.com/bigmarch/BigMarch/blob/master/Assets/BigMarch/Swizzle/Swizzle.cs
using UnityEngine;


namespace Extension.Vector
{
	public static class SwizzleVector2IntTo2Int
	{
		public static Vector2Int xx(this Vector2Int v) { return new Vector2Int(v.x, v.x); }
		public static Vector2Int xy(this Vector2Int v) { return new Vector2Int(v.x, v.y); }
		public static Vector2Int yx(this Vector2Int v) { return new Vector2Int(v.y, v.x); }
		public static Vector2Int yy(this Vector2Int v) { return new Vector2Int(v.y, v.y); }
	}


	public static class SwizzleVector3IntTo2Int
	{
		public static Vector2Int xx(this Vector3Int v) { return new Vector2Int(v.x, v.x); }
		public static Vector2Int xy(this Vector3Int v) { return new Vector2Int(v.x, v.y); }
		public static Vector2Int xz(this Vector3Int v) { return new Vector2Int(v.x, v.z); }
		public static Vector2Int yx(this Vector3Int v) { return new Vector2Int(v.y, v.x); }
		public static Vector2Int yy(this Vector3Int v) { return new Vector2Int(v.y, v.y); }
		public static Vector2Int yz(this Vector3Int v) { return new Vector2Int(v.y, v.z); }
		public static Vector2Int zx(this Vector3Int v) { return new Vector2Int(v.z, v.x); }
		public static Vector2Int zy(this Vector3Int v) { return new Vector2Int(v.z, v.y); }
		public static Vector2Int zz(this Vector3Int v) { return new Vector2Int(v.z, v.z); }
	}


	public static class SwizzleVector2IntTo3Int
	{
		public static Vector3Int xxx(this Vector2Int v       ) { return new Vector3Int(v.x, v.x, v.x); }
		public static Vector3Int xxy(this Vector2Int v       ) { return new Vector3Int(v.x, v.x, v.y); }
		public static Vector3Int xxz(this Vector2Int v, int z) { return new Vector3Int(v.x, v.x,   z); }
		public static Vector3Int xyx(this Vector2Int v       ) { return new Vector3Int(v.x, v.y, v.x); }
		public static Vector3Int xyy(this Vector2Int v       ) { return new Vector3Int(v.x, v.y, v.y); }
		public static Vector3Int xyz(this Vector2Int v, int z) { return new Vector3Int(v.x, v.y,   z); }
		public static Vector3Int xzx(this Vector2Int v, int z) { return new Vector3Int(v.x,   z, v.x); }
		public static Vector3Int xzy(this Vector2Int v, int z) { return new Vector3Int(v.x,   z, v.y); }
		public static Vector3Int xzz(this Vector2Int v, int z) { return new Vector3Int(v.x,   z,   z); }
		public static Vector3Int yxx(this Vector2Int v       ) { return new Vector3Int(v.y, v.x, v.x); }
		public static Vector3Int yxy(this Vector2Int v       ) { return new Vector3Int(v.y, v.x, v.y); }
		public static Vector3Int yxz(this Vector2Int v, int z) { return new Vector3Int(v.y, v.x,   z); }
		public static Vector3Int yyx(this Vector2Int v       ) { return new Vector3Int(v.y, v.y, v.x); }
		public static Vector3Int yyy(this Vector2Int v       ) { return new Vector3Int(v.y, v.y, v.y); }
		public static Vector3Int yyz(this Vector2Int v, int z) { return new Vector3Int(v.y, v.y,   z); }
		public static Vector3Int yzx(this Vector2Int v, int z) { return new Vector3Int(v.y,   z, v.x); }
		public static Vector3Int yzy(this Vector2Int v, int z) { return new Vector3Int(v.y,   z, v.y); }
		public static Vector3Int yzz(this Vector2Int v, int z) { return new Vector3Int(v.y,   z,   z); }
		public static Vector3Int zxx(this Vector2Int v, int z) { return new Vector3Int(  z, v.x, v.x); }
		public static Vector3Int zxy(this Vector2Int v, int z) { return new Vector3Int(  z, v.x, v.y); }
		public static Vector3Int zxz(this Vector2Int v, int z) { return new Vector3Int(  z, v.x,   z); }
		public static Vector3Int zyx(this Vector2Int v, int z) { return new Vector3Int(  z, v.y, v.x); }
		public static Vector3Int zyy(this Vector2Int v, int z) { return new Vector3Int(  z, v.y, v.y); }
		public static Vector3Int zyz(this Vector2Int v, int z) { return new Vector3Int(  z, v.y,   z); }
		public static Vector3Int zzx(this Vector2Int v, int z) { return new Vector3Int(  z,   z, v.x); }
		public static Vector3Int zzy(this Vector2Int v, int z) { return new Vector3Int(  z,   z, v.y); }
		public static Vector3Int zzz(this Vector2Int v, int z) { return new Vector3Int(  z,   z,   z); }
	}


	public static class SwizzleVector3IntTo3Int
	{
		public static Vector3Int xxx(this Vector3Int v) { return new Vector3Int(v.x, v.x, v.x); }
		public static Vector3Int xxy(this Vector3Int v) { return new Vector3Int(v.x, v.x, v.y); }
		public static Vector3Int xxz(this Vector3Int v) { return new Vector3Int(v.x, v.x, v.z); }
		public static Vector3Int xyx(this Vector3Int v) { return new Vector3Int(v.x, v.y, v.x); }
		public static Vector3Int xyy(this Vector3Int v) { return new Vector3Int(v.x, v.y, v.y); }
		public static Vector3Int xyz(this Vector3Int v) { return new Vector3Int(v.x, v.y, v.z); }
		public static Vector3Int xzx(this Vector3Int v) { return new Vector3Int(v.x, v.z, v.x); }
		public static Vector3Int xzy(this Vector3Int v) { return new Vector3Int(v.x, v.z, v.y); }
		public static Vector3Int xzz(this Vector3Int v) { return new Vector3Int(v.x, v.z, v.z); }
		public static Vector3Int yxx(this Vector3Int v) { return new Vector3Int(v.y, v.x, v.x); }
		public static Vector3Int yxy(this Vector3Int v) { return new Vector3Int(v.y, v.x, v.y); }
		public static Vector3Int yxz(this Vector3Int v) { return new Vector3Int(v.y, v.x, v.z); }
		public static Vector3Int yyx(this Vector3Int v) { return new Vector3Int(v.y, v.y, v.x); }
		public static Vector3Int yyy(this Vector3Int v) { return new Vector3Int(v.y, v.y, v.y); }
		public static Vector3Int yyz(this Vector3Int v) { return new Vector3Int(v.y, v.y, v.z); }
		public static Vector3Int yzx(this Vector3Int v) { return new Vector3Int(v.y, v.z, v.x); }
		public static Vector3Int yzy(this Vector3Int v) { return new Vector3Int(v.y, v.z, v.y); }
		public static Vector3Int yzz(this Vector3Int v) { return new Vector3Int(v.y, v.z, v.z); }
		public static Vector3Int zxx(this Vector3Int v) { return new Vector3Int(v.z, v.x, v.x); }
		public static Vector3Int zxy(this Vector3Int v) { return new Vector3Int(v.z, v.x, v.y); }
		public static Vector3Int zxz(this Vector3Int v) { return new Vector3Int(v.z, v.x, v.z); }
		public static Vector3Int zyx(this Vector3Int v) { return new Vector3Int(v.z, v.y, v.x); }
		public static Vector3Int zyy(this Vector3Int v) { return new Vector3Int(v.z, v.y, v.y); }
		public static Vector3Int zyz(this Vector3Int v) { return new Vector3Int(v.z, v.y, v.z); }
		public static Vector3Int zzx(this Vector3Int v) { return new Vector3Int(v.z, v.z, v.x); }
		public static Vector3Int zzy(this Vector3Int v) { return new Vector3Int(v.z, v.z, v.y); }
		public static Vector3Int zzz(this Vector3Int v) { return new Vector3Int(v.z, v.z, v.z); }
	}
}
