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


	public static class SwizzleVector4IntTo2Int
	{
		public static Vector2Int xx(this Vector4Int v) { return new Vector2Int(v.x, v.x); }
		public static Vector2Int xy(this Vector4Int v) { return new Vector2Int(v.x, v.y); }
		public static Vector2Int xz(this Vector4Int v) { return new Vector2Int(v.x, v.z); }
		public static Vector2Int xw(this Vector4Int v) { return new Vector2Int(v.x, v.w); }
		public static Vector2Int yx(this Vector4Int v) { return new Vector2Int(v.y, v.x); }
		public static Vector2Int yy(this Vector4Int v) { return new Vector2Int(v.y, v.y); }
		public static Vector2Int yz(this Vector4Int v) { return new Vector2Int(v.y, v.z); }
		public static Vector2Int yw(this Vector4Int v) { return new Vector2Int(v.y, v.w); }
		public static Vector2Int zx(this Vector4Int v) { return new Vector2Int(v.z, v.x); }
		public static Vector2Int zy(this Vector4Int v) { return new Vector2Int(v.z, v.y); }
		public static Vector2Int zz(this Vector4Int v) { return new Vector2Int(v.z, v.z); }
		public static Vector2Int zw(this Vector4Int v) { return new Vector2Int(v.z, v.w); }
		public static Vector2Int wx(this Vector4Int v) { return new Vector2Int(v.w, v.x); }
		public static Vector2Int wy(this Vector4Int v) { return new Vector2Int(v.w, v.y); }
		public static Vector2Int wz(this Vector4Int v) { return new Vector2Int(v.w, v.z); }
		public static Vector2Int ww(this Vector4Int v) { return new Vector2Int(v.w, v.w); }
	}


	public static class SwizzleVector2IntTo3Int
	{
		public static Vector3Int xxx(this Vector2Int v         ) { return new Vector3Int(v.x, v.x, v.x); }
		public static Vector3Int xxy(this Vector2Int v         ) { return new Vector3Int(v.x, v.x, v.y); }
		public static Vector3Int xxz(this Vector2Int v, float z) { return new Vector3Int(v.x, v.x,   z); }
		public static Vector3Int xyx(this Vector2Int v         ) { return new Vector3Int(v.x, v.y, v.x); }
		public static Vector3Int xyy(this Vector2Int v         ) { return new Vector3Int(v.x, v.y, v.y); }
		public static Vector3Int xyz(this Vector2Int v, float z) { return new Vector3Int(v.x, v.y,   z); }
		public static Vector3Int xzx(this Vector2Int v, float z) { return new Vector3Int(v.x,   z, v.x); }
		public static Vector3Int xzy(this Vector2Int v, float z) { return new Vector3Int(v.x,   z, v.y); }
		public static Vector3Int xzz(this Vector2Int v, float z) { return new Vector3Int(v.x,   z,   z); }
		public static Vector3Int yxx(this Vector2Int v         ) { return new Vector3Int(v.y, v.x, v.x); }
		public static Vector3Int yxy(this Vector2Int v         ) { return new Vector3Int(v.y, v.x, v.y); }
		public static Vector3Int yxz(this Vector2Int v, float z) { return new Vector3Int(v.y, v.x,   z); }
		public static Vector3Int yyx(this Vector2Int v         ) { return new Vector3Int(v.y, v.y, v.x); }
		public static Vector3Int yyy(this Vector2Int v         ) { return new Vector3Int(v.y, v.y, v.y); }
		public static Vector3Int yyz(this Vector2Int v, float z) { return new Vector3Int(v.y, v.y,   z); }
		public static Vector3Int yzx(this Vector2Int v, float z) { return new Vector3Int(v.y,   z, v.x); }
		public static Vector3Int yzy(this Vector2Int v, float z) { return new Vector3Int(v.y,   z, v.y); }
		public static Vector3Int yzz(this Vector2Int v, float z) { return new Vector3Int(v.y,   z,   z); }
		public static Vector3Int zxx(this Vector2Int v, float z) { return new Vector3Int(  z, v.x, v.x); }
		public static Vector3Int zxy(this Vector2Int v, float z) { return new Vector3Int(  z, v.x, v.y); }
		public static Vector3Int zxz(this Vector2Int v, float z) { return new Vector3Int(  z, v.x,   z); }
		public static Vector3Int zyx(this Vector2Int v, float z) { return new Vector3Int(  z, v.y, v.x); }
		public static Vector3Int zyy(this Vector2Int v, float z) { return new Vector3Int(  z, v.y, v.y); }
		public static Vector3Int zyz(this Vector2Int v, float z) { return new Vector3Int(  z, v.y,   z); }
		public static Vector3Int zzx(this Vector2Int v, float z) { return new Vector3Int(  z,   z, v.x); }
		public static Vector3Int zzy(this Vector2Int v, float z) { return new Vector3Int(  z,   z, v.y); }
		public static Vector3Int zzz(this Vector2Int v, float z) { return new Vector3Int(  z,   z,   z); }
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


	public static class SwizzleVector4IntTo3Int
	{
		public static Vector3Int xxx(this Vector4Int v) { return new Vector3Int(v.x, v.x, v.x); }
		public static Vector3Int xxy(this Vector4Int v) { return new Vector3Int(v.x, v.x, v.y); }
		public static Vector3Int xxz(this Vector4Int v) { return new Vector3Int(v.x, v.x, v.z); }
		public static Vector3Int xxw(this Vector4Int v) { return new Vector3Int(v.x, v.x, v.w); }
		public static Vector3Int xyx(this Vector4Int v) { return new Vector3Int(v.x, v.y, v.x); }
		public static Vector3Int xyy(this Vector4Int v) { return new Vector3Int(v.x, v.y, v.y); }
		public static Vector3Int xyz(this Vector4Int v) { return new Vector3Int(v.x, v.y, v.z); }
		public static Vector3Int xyw(this Vector4Int v) { return new Vector3Int(v.x, v.y, v.w); }
		public static Vector3Int xzx(this Vector4Int v) { return new Vector3Int(v.x, v.z, v.x); }
		public static Vector3Int xzy(this Vector4Int v) { return new Vector3Int(v.x, v.z, v.y); }
		public static Vector3Int xzz(this Vector4Int v) { return new Vector3Int(v.x, v.z, v.z); }
		public static Vector3Int xzw(this Vector4Int v) { return new Vector3Int(v.x, v.z, v.w); }
		public static Vector3Int xwx(this Vector4Int v) { return new Vector3Int(v.x, v.w, v.x); }
		public static Vector3Int xwy(this Vector4Int v) { return new Vector3Int(v.x, v.w, v.y); }
		public static Vector3Int xwz(this Vector4Int v) { return new Vector3Int(v.x, v.w, v.z); }
		public static Vector3Int xww(this Vector4Int v) { return new Vector3Int(v.x, v.w, v.w); }
		public static Vector3Int yxx(this Vector4Int v) { return new Vector3Int(v.y, v.x, v.x); }
		public static Vector3Int yxy(this Vector4Int v) { return new Vector3Int(v.y, v.x, v.y); }
		public static Vector3Int yxz(this Vector4Int v) { return new Vector3Int(v.y, v.x, v.z); }
		public static Vector3Int yxw(this Vector4Int v) { return new Vector3Int(v.y, v.x, v.w); }
		public static Vector3Int yyx(this Vector4Int v) { return new Vector3Int(v.y, v.y, v.x); }
		public static Vector3Int yyy(this Vector4Int v) { return new Vector3Int(v.y, v.y, v.y); }
		public static Vector3Int yyz(this Vector4Int v) { return new Vector3Int(v.y, v.y, v.z); }
		public static Vector3Int yyw(this Vector4Int v) { return new Vector3Int(v.y, v.y, v.w); }
		public static Vector3Int yzx(this Vector4Int v) { return new Vector3Int(v.y, v.z, v.x); }
		public static Vector3Int yzy(this Vector4Int v) { return new Vector3Int(v.y, v.z, v.y); }
		public static Vector3Int yzz(this Vector4Int v) { return new Vector3Int(v.y, v.z, v.z); }
		public static Vector3Int yzw(this Vector4Int v) { return new Vector3Int(v.y, v.z, v.w); }
		public static Vector3Int ywx(this Vector4Int v) { return new Vector3Int(v.y, v.w, v.x); }
		public static Vector3Int ywy(this Vector4Int v) { return new Vector3Int(v.y, v.w, v.y); }
		public static Vector3Int ywz(this Vector4Int v) { return new Vector3Int(v.y, v.w, v.z); }
		public static Vector3Int yww(this Vector4Int v) { return new Vector3Int(v.y, v.w, v.w); }
		public static Vector3Int zxx(this Vector4Int v) { return new Vector3Int(v.z, v.x, v.x); }
		public static Vector3Int zxy(this Vector4Int v) { return new Vector3Int(v.z, v.x, v.y); }
		public static Vector3Int zxz(this Vector4Int v) { return new Vector3Int(v.z, v.x, v.z); }
		public static Vector3Int zxw(this Vector4Int v) { return new Vector3Int(v.z, v.x, v.w); }
		public static Vector3Int zyx(this Vector4Int v) { return new Vector3Int(v.z, v.y, v.x); }
		public static Vector3Int zyy(this Vector4Int v) { return new Vector3Int(v.z, v.y, v.y); }
		public static Vector3Int zyz(this Vector4Int v) { return new Vector3Int(v.z, v.y, v.z); }
		public static Vector3Int zyw(this Vector4Int v) { return new Vector3Int(v.z, v.y, v.w); }
		public static Vector3Int zzx(this Vector4Int v) { return new Vector3Int(v.z, v.z, v.x); }
		public static Vector3Int zzy(this Vector4Int v) { return new Vector3Int(v.z, v.z, v.y); }
		public static Vector3Int zzz(this Vector4Int v) { return new Vector3Int(v.z, v.z, v.z); }
		public static Vector3Int zzw(this Vector4Int v) { return new Vector3Int(v.z, v.z, v.w); }
		public static Vector3Int zwx(this Vector4Int v) { return new Vector3Int(v.z, v.w, v.x); }
		public static Vector3Int zwy(this Vector4Int v) { return new Vector3Int(v.z, v.w, v.y); }
		public static Vector3Int zwz(this Vector4Int v) { return new Vector3Int(v.z, v.w, v.z); }
		public static Vector3Int zww(this Vector4Int v) { return new Vector3Int(v.z, v.w, v.w); }
		public static Vector3Int wxx(this Vector4Int v) { return new Vector3Int(v.w, v.x, v.x); }
		public static Vector3Int wxy(this Vector4Int v) { return new Vector3Int(v.w, v.x, v.y); }
		public static Vector3Int wxz(this Vector4Int v) { return new Vector3Int(v.w, v.x, v.z); }
		public static Vector3Int wxw(this Vector4Int v) { return new Vector3Int(v.w, v.x, v.w); }
		public static Vector3Int wyx(this Vector4Int v) { return new Vector3Int(v.w, v.y, v.x); }
		public static Vector3Int wyy(this Vector4Int v) { return new Vector3Int(v.w, v.y, v.y); }
		public static Vector3Int wyz(this Vector4Int v) { return new Vector3Int(v.w, v.y, v.z); }
		public static Vector3Int wyw(this Vector4Int v) { return new Vector3Int(v.w, v.y, v.w); }
		public static Vector3Int wzx(this Vector4Int v) { return new Vector3Int(v.w, v.z, v.x); }
		public static Vector3Int wzy(this Vector4Int v) { return new Vector3Int(v.w, v.z, v.y); }
		public static Vector3Int wzz(this Vector4Int v) { return new Vector3Int(v.w, v.z, v.z); }
		public static Vector3Int wzw(this Vector4Int v) { return new Vector3Int(v.w, v.z, v.w); }
		public static Vector3Int wwx(this Vector4Int v) { return new Vector3Int(v.w, v.w, v.x); }
		public static Vector3Int wwy(this Vector4Int v) { return new Vector3Int(v.w, v.w, v.y); }
		public static Vector3Int wwz(this Vector4Int v) { return new Vector3Int(v.w, v.w, v.z); }
		public static Vector3Int www(this Vector4Int v) { return new Vector3Int(v.w, v.w, v.w); }
	}


	public static class SwizzleVector2IntTo4Int
	{
		public static Vector4Int xxxx(this Vector2Int v                  ) { return new Vector4Int(v.x, v.x, v.x, v.x); }
		public static Vector4Int xxxy(this Vector2Int v                  ) { return new Vector4Int(v.x, v.x, v.x, v.y); }
		public static Vector4Int xxxz(this Vector2Int v, float z         ) { return new Vector4Int(v.x, v.x, v.x,   z); }
		public static Vector4Int xxxw(this Vector2Int v, float w         ) { return new Vector4Int(v.x, v.x, v.x,   w); }
		public static Vector4Int xxyx(this Vector2Int v                  ) { return new Vector4Int(v.x, v.x, v.y, v.x); }
		public static Vector4Int xxyy(this Vector2Int v                  ) { return new Vector4Int(v.x, v.x, v.y, v.y); }
		public static Vector4Int xxyz(this Vector2Int v, float z         ) { return new Vector4Int(v.x, v.x, v.y,   z); }
		public static Vector4Int xxyw(this Vector2Int v, float w         ) { return new Vector4Int(v.x, v.x, v.y,   w); }
		public static Vector4Int xxzx(this Vector2Int v, float z         ) { return new Vector4Int(v.x, v.x,   z, v.x); }
		public static Vector4Int xxzy(this Vector2Int v, float z         ) { return new Vector4Int(v.x, v.x,   z, v.y); }
		public static Vector4Int xxzz(this Vector2Int v, float z         ) { return new Vector4Int(v.x, v.x,   z,   z); }
		public static Vector4Int xxzw(this Vector2Int v, float z, float w) { return new Vector4Int(v.x, v.x,   z,   w); }
		public static Vector4Int xxwx(this Vector2Int v, float w         ) { return new Vector4Int(v.x, v.x,   w, v.x); }
		public static Vector4Int xxwy(this Vector2Int v, float w         ) { return new Vector4Int(v.x, v.x,   w, v.y); }
		public static Vector4Int xxwz(this Vector2Int v, float z, float w) { return new Vector4Int(v.x, v.x,   w,   z); }
		public static Vector4Int xxww(this Vector2Int v, float w         ) { return new Vector4Int(v.x, v.x,   w,   w); }
		public static Vector4Int xyxx(this Vector2Int v                  ) { return new Vector4Int(v.x, v.y, v.x, v.x); }
		public static Vector4Int xyxy(this Vector2Int v                  ) { return new Vector4Int(v.x, v.y, v.x, v.y); }
		public static Vector4Int xyxz(this Vector2Int v, float z         ) { return new Vector4Int(v.x, v.y, v.x,   z); }
		public static Vector4Int xyxw(this Vector2Int v, float w         ) { return new Vector4Int(v.x, v.y, v.x,   w); }
		public static Vector4Int xyyx(this Vector2Int v                  ) { return new Vector4Int(v.x, v.y, v.y, v.x); }
		public static Vector4Int xyyy(this Vector2Int v                  ) { return new Vector4Int(v.x, v.y, v.y, v.y); }
		public static Vector4Int xyyz(this Vector2Int v, float z         ) { return new Vector4Int(v.x, v.y, v.y,   z); }
		public static Vector4Int xyyw(this Vector2Int v, float w         ) { return new Vector4Int(v.x, v.y, v.y,   w); }
		public static Vector4Int xyzx(this Vector2Int v, float z         ) { return new Vector4Int(v.x, v.y,   z, v.x); }
		public static Vector4Int xyzy(this Vector2Int v, float z         ) { return new Vector4Int(v.x, v.y,   z, v.y); }
		public static Vector4Int xyzz(this Vector2Int v, float z         ) { return new Vector4Int(v.x, v.y,   z,   z); }
		public static Vector4Int xyzw(this Vector2Int v, float z, float w) { return new Vector4Int(v.x, v.y,   z,   w); }
		public static Vector4Int xywx(this Vector2Int v, float w         ) { return new Vector4Int(v.x, v.y,   w, v.x); }
		public static Vector4Int xywy(this Vector2Int v, float w         ) { return new Vector4Int(v.x, v.y,   w, v.y); }
		public static Vector4Int xywz(this Vector2Int v, float z, float w) { return new Vector4Int(v.x, v.y,   w,   z); }
		public static Vector4Int xyww(this Vector2Int v, float w         ) { return new Vector4Int(v.x, v.y,   w,   w); }
		public static Vector4Int xzxx(this Vector2Int v, float z         ) { return new Vector4Int(v.x,   z, v.x, v.x); }
		public static Vector4Int xzxy(this Vector2Int v, float z         ) { return new Vector4Int(v.x,   z, v.x, v.y); }
		public static Vector4Int xzxz(this Vector2Int v, float z         ) { return new Vector4Int(v.x,   z, v.x,   z); }
		public static Vector4Int xzxw(this Vector2Int v, float z, float w) { return new Vector4Int(v.x,   z, v.x,   w); }
		public static Vector4Int xzyx(this Vector2Int v, float z         ) { return new Vector4Int(v.x,   z, v.y, v.x); }
		public static Vector4Int xzyy(this Vector2Int v, float z         ) { return new Vector4Int(v.x,   z, v.y, v.y); }
		public static Vector4Int xzyz(this Vector2Int v, float z         ) { return new Vector4Int(v.x,   z, v.y,   z); }
		public static Vector4Int xzyw(this Vector2Int v, float z, float w) { return new Vector4Int(v.x,   z, v.y,   w); }
		public static Vector4Int xzzx(this Vector2Int v, float z         ) { return new Vector4Int(v.x,   z,   z, v.x); }
		public static Vector4Int xzzy(this Vector2Int v, float z         ) { return new Vector4Int(v.x,   z,   z, v.y); }
		public static Vector4Int xzzz(this Vector2Int v, float z         ) { return new Vector4Int(v.x,   z,   z,   z); }
		public static Vector4Int xzzw(this Vector2Int v, float z, float w) { return new Vector4Int(v.x,   z,   z,   w); }
		public static Vector4Int xzwx(this Vector2Int v, float z, float w) { return new Vector4Int(v.x,   z,   w, v.x); }
		public static Vector4Int xzwy(this Vector2Int v, float z, float w) { return new Vector4Int(v.x,   z,   w, v.y); }
		public static Vector4Int xzwz(this Vector2Int v, float z, float w) { return new Vector4Int(v.x,   z,   w,   z); }
		public static Vector4Int xzww(this Vector2Int v, float z, float w) { return new Vector4Int(v.x,   z,   w,   w); }
		public static Vector4Int xwxx(this Vector2Int v, float w         ) { return new Vector4Int(v.x,   w, v.x, v.x); }
		public static Vector4Int xwxy(this Vector2Int v, float w         ) { return new Vector4Int(v.x,   w, v.x, v.y); }
		public static Vector4Int xwxz(this Vector2Int v, float z, float w) { return new Vector4Int(v.x,   w, v.x,   z); }
		public static Vector4Int xwxw(this Vector2Int v, float w         ) { return new Vector4Int(v.x,   w, v.x,   w); }
		public static Vector4Int xwyx(this Vector2Int v, float w         ) { return new Vector4Int(v.x,   w, v.y, v.x); }
		public static Vector4Int xwyy(this Vector2Int v, float w         ) { return new Vector4Int(v.x,   w, v.y, v.y); }
		public static Vector4Int xwyz(this Vector2Int v, float z, float w) { return new Vector4Int(v.x,   w, v.y,   z); }
		public static Vector4Int xwyw(this Vector2Int v, float w         ) { return new Vector4Int(v.x,   w, v.y,   w); }
		public static Vector4Int xwzx(this Vector2Int v, float z, float w) { return new Vector4Int(v.x,   w,   z, v.x); }
		public static Vector4Int xwzy(this Vector2Int v, float z, float w) { return new Vector4Int(v.x,   w,   z, v.y); }
		public static Vector4Int xwzz(this Vector2Int v, float z, float w) { return new Vector4Int(v.x,   w,   z,   z); }
		public static Vector4Int xwzw(this Vector2Int v, float z, float w) { return new Vector4Int(v.x,   w,   z,   w); }
		public static Vector4Int xwwx(this Vector2Int v, float w         ) { return new Vector4Int(v.x,   w,   w, v.x); }
		public static Vector4Int xwwy(this Vector2Int v, float w         ) { return new Vector4Int(v.x,   w,   w, v.y); }
		public static Vector4Int xwwz(this Vector2Int v, float z, float w) { return new Vector4Int(v.x,   w,   w,   z); }
		public static Vector4Int xwww(this Vector2Int v, float w         ) { return new Vector4Int(v.x,   w,   w,   w); }
		public static Vector4Int yxxx(this Vector2Int v                  ) { return new Vector4Int(v.y, v.x, v.x, v.x); }
		public static Vector4Int yxxy(this Vector2Int v                  ) { return new Vector4Int(v.y, v.x, v.x, v.y); }
		public static Vector4Int yxxz(this Vector2Int v, float z         ) { return new Vector4Int(v.y, v.x, v.x,   z); }
		public static Vector4Int yxxw(this Vector2Int v, float w         ) { return new Vector4Int(v.y, v.x, v.x,   w); }
		public static Vector4Int yxyx(this Vector2Int v                  ) { return new Vector4Int(v.y, v.x, v.y, v.x); }
		public static Vector4Int yxyy(this Vector2Int v                  ) { return new Vector4Int(v.y, v.x, v.y, v.y); }
		public static Vector4Int yxyz(this Vector2Int v, float z         ) { return new Vector4Int(v.y, v.x, v.y,   z); }
		public static Vector4Int yxyw(this Vector2Int v, float w         ) { return new Vector4Int(v.y, v.x, v.y,   w); }
		public static Vector4Int yxzx(this Vector2Int v, float z         ) { return new Vector4Int(v.y, v.x,   z, v.x); }
		public static Vector4Int yxzy(this Vector2Int v, float z         ) { return new Vector4Int(v.y, v.x,   z, v.y); }
		public static Vector4Int yxzz(this Vector2Int v, float z         ) { return new Vector4Int(v.y, v.x,   z,   z); }
		public static Vector4Int yxzw(this Vector2Int v, float z, float w) { return new Vector4Int(v.y, v.x,   z,   w); }
		public static Vector4Int yxwx(this Vector2Int v, float w         ) { return new Vector4Int(v.y, v.x,   w, v.x); }
		public static Vector4Int yxwy(this Vector2Int v, float w         ) { return new Vector4Int(v.y, v.x,   w, v.y); }
		public static Vector4Int yxwz(this Vector2Int v, float z, float w) { return new Vector4Int(v.y, v.x,   w,   z); }
		public static Vector4Int yxww(this Vector2Int v, float w         ) { return new Vector4Int(v.y, v.x,   w,   w); }
		public static Vector4Int yyxx(this Vector2Int v                  ) { return new Vector4Int(v.y, v.y, v.x, v.x); }
		public static Vector4Int yyxy(this Vector2Int v                  ) { return new Vector4Int(v.y, v.y, v.x, v.y); }
		public static Vector4Int yyxz(this Vector2Int v, float z         ) { return new Vector4Int(v.y, v.y, v.x,   z); }
		public static Vector4Int yyxw(this Vector2Int v, float w         ) { return new Vector4Int(v.y, v.y, v.x,   w); }
		public static Vector4Int yyyx(this Vector2Int v                  ) { return new Vector4Int(v.y, v.y, v.y, v.x); }
		public static Vector4Int yyyy(this Vector2Int v                  ) { return new Vector4Int(v.y, v.y, v.y, v.y); }
		public static Vector4Int yyyz(this Vector2Int v, float z         ) { return new Vector4Int(v.y, v.y, v.y,   z); }
		public static Vector4Int yyyw(this Vector2Int v, float w         ) { return new Vector4Int(v.y, v.y, v.y,   w); }
		public static Vector4Int yyzx(this Vector2Int v, float z         ) { return new Vector4Int(v.y, v.y,   z, v.x); }
		public static Vector4Int yyzy(this Vector2Int v, float z         ) { return new Vector4Int(v.y, v.y,   z, v.y); }
		public static Vector4Int yyzz(this Vector2Int v, float z         ) { return new Vector4Int(v.y, v.y,   z,   z); }
		public static Vector4Int yyzw(this Vector2Int v, float z, float w) { return new Vector4Int(v.y, v.y,   z,   w); }
		public static Vector4Int yywx(this Vector2Int v, float w         ) { return new Vector4Int(v.y, v.y,   w, v.x); }
		public static Vector4Int yywy(this Vector2Int v, float w         ) { return new Vector4Int(v.y, v.y,   w, v.y); }
		public static Vector4Int yywz(this Vector2Int v, float z, float w) { return new Vector4Int(v.y, v.y,   w,   z); }
		public static Vector4Int yyww(this Vector2Int v, float w         ) { return new Vector4Int(v.y, v.y,   w,   w); }
		public static Vector4Int yzxx(this Vector2Int v, float z         ) { return new Vector4Int(v.y,   z, v.x, v.x); }
		public static Vector4Int yzxy(this Vector2Int v, float z         ) { return new Vector4Int(v.y,   z, v.x, v.y); }
		public static Vector4Int yzxz(this Vector2Int v, float z         ) { return new Vector4Int(v.y,   z, v.x,   z); }
		public static Vector4Int yzxw(this Vector2Int v, float z, float w) { return new Vector4Int(v.y,   z, v.x,   w); }
		public static Vector4Int yzyx(this Vector2Int v, float z         ) { return new Vector4Int(v.y,   z, v.y, v.x); }
		public static Vector4Int yzyy(this Vector2Int v, float z         ) { return new Vector4Int(v.y,   z, v.y, v.y); }
		public static Vector4Int yzyz(this Vector2Int v, float z         ) { return new Vector4Int(v.y,   z, v.y,   z); }
		public static Vector4Int yzyw(this Vector2Int v, float z, float w) { return new Vector4Int(v.y,   z, v.y,   w); }
		public static Vector4Int yzzx(this Vector2Int v, float z         ) { return new Vector4Int(v.y,   z,   z, v.x); }
		public static Vector4Int yzzy(this Vector2Int v, float z         ) { return new Vector4Int(v.y,   z,   z, v.y); }
		public static Vector4Int yzzz(this Vector2Int v, float z         ) { return new Vector4Int(v.y,   z,   z,   z); }
		public static Vector4Int yzzw(this Vector2Int v, float z, float w) { return new Vector4Int(v.y,   z,   z,   w); }
		public static Vector4Int yzwx(this Vector2Int v, float z, float w) { return new Vector4Int(v.y,   z,   w, v.x); }
		public static Vector4Int yzwy(this Vector2Int v, float z, float w) { return new Vector4Int(v.y,   z,   w, v.y); }
		public static Vector4Int yzwz(this Vector2Int v, float z, float w) { return new Vector4Int(v.y,   z,   w,   z); }
		public static Vector4Int yzww(this Vector2Int v, float z, float w) { return new Vector4Int(v.y,   z,   w,   w); }
		public static Vector4Int ywxx(this Vector2Int v, float w         ) { return new Vector4Int(v.y,   w, v.x, v.x); }
		public static Vector4Int ywxy(this Vector2Int v, float w         ) { return new Vector4Int(v.y,   w, v.x, v.y); }
		public static Vector4Int ywxz(this Vector2Int v, float z, float w) { return new Vector4Int(v.y,   w, v.x,   z); }
		public static Vector4Int ywxw(this Vector2Int v, float w         ) { return new Vector4Int(v.y,   w, v.x,   w); }
		public static Vector4Int ywyx(this Vector2Int v, float w         ) { return new Vector4Int(v.y,   w, v.y, v.x); }
		public static Vector4Int ywyy(this Vector2Int v, float w         ) { return new Vector4Int(v.y,   w, v.y, v.y); }
		public static Vector4Int ywyz(this Vector2Int v, float z, float w) { return new Vector4Int(v.y,   w, v.y,   z); }
		public static Vector4Int ywyw(this Vector2Int v, float w         ) { return new Vector4Int(v.y,   w, v.y,   w); }
		public static Vector4Int ywzx(this Vector2Int v, float z, float w) { return new Vector4Int(v.y,   w,   z, v.x); }
		public static Vector4Int ywzy(this Vector2Int v, float z, float w) { return new Vector4Int(v.y,   w,   z, v.y); }
		public static Vector4Int ywzz(this Vector2Int v, float z, float w) { return new Vector4Int(v.y,   w,   z,   z); }
		public static Vector4Int ywzw(this Vector2Int v, float z, float w) { return new Vector4Int(v.y,   w,   z,   w); }
		public static Vector4Int ywwx(this Vector2Int v, float w         ) { return new Vector4Int(v.y,   w,   w, v.x); }
		public static Vector4Int ywwy(this Vector2Int v, float w         ) { return new Vector4Int(v.y,   w,   w, v.y); }
		public static Vector4Int ywwz(this Vector2Int v, float z, float w) { return new Vector4Int(v.y,   w,   w,   z); }
		public static Vector4Int ywww(this Vector2Int v, float w         ) { return new Vector4Int(v.y,   w,   w,   w); }
		public static Vector4Int zxxx(this Vector2Int v, float z         ) { return new Vector4Int(  z, v.x, v.x, v.x); }
		public static Vector4Int zxxy(this Vector2Int v, float z         ) { return new Vector4Int(  z, v.x, v.x, v.y); }
		public static Vector4Int zxxz(this Vector2Int v, float z         ) { return new Vector4Int(  z, v.x, v.x,   z); }
		public static Vector4Int zxxw(this Vector2Int v, float z, float w) { return new Vector4Int(  z, v.x, v.x,   w); }
		public static Vector4Int zxyx(this Vector2Int v, float z         ) { return new Vector4Int(  z, v.x, v.y, v.x); }
		public static Vector4Int zxyy(this Vector2Int v, float z         ) { return new Vector4Int(  z, v.x, v.y, v.y); }
		public static Vector4Int zxyz(this Vector2Int v, float z         ) { return new Vector4Int(  z, v.x, v.y,   z); }
		public static Vector4Int zxyw(this Vector2Int v, float z, float w) { return new Vector4Int(  z, v.x, v.y,   w); }
		public static Vector4Int zxzx(this Vector2Int v, float z         ) { return new Vector4Int(  z, v.x,   z, v.x); }
		public static Vector4Int zxzy(this Vector2Int v, float z         ) { return new Vector4Int(  z, v.x,   z, v.y); }
		public static Vector4Int zxzz(this Vector2Int v, float z         ) { return new Vector4Int(  z, v.x,   z,   z); }
		public static Vector4Int zxzw(this Vector2Int v, float z, float w) { return new Vector4Int(  z, v.x,   z,   w); }
		public static Vector4Int zxwx(this Vector2Int v, float z, float w) { return new Vector4Int(  z, v.x,   w, v.x); }
		public static Vector4Int zxwy(this Vector2Int v, float z, float w) { return new Vector4Int(  z, v.x,   w, v.y); }
		public static Vector4Int zxwz(this Vector2Int v, float z, float w) { return new Vector4Int(  z, v.x,   w,   z); }
		public static Vector4Int zxww(this Vector2Int v, float z, float w) { return new Vector4Int(  z, v.x,   w,   w); }
		public static Vector4Int zyxx(this Vector2Int v, float z         ) { return new Vector4Int(  z, v.y, v.x, v.x); }
		public static Vector4Int zyxy(this Vector2Int v, float z         ) { return new Vector4Int(  z, v.y, v.x, v.y); }
		public static Vector4Int zyxz(this Vector2Int v, float z         ) { return new Vector4Int(  z, v.y, v.x,   z); }
		public static Vector4Int zyxw(this Vector2Int v, float z, float w) { return new Vector4Int(  z, v.y, v.x,   w); }
		public static Vector4Int zyyx(this Vector2Int v, float z         ) { return new Vector4Int(  z, v.y, v.y, v.x); }
		public static Vector4Int zyyy(this Vector2Int v, float z         ) { return new Vector4Int(  z, v.y, v.y, v.y); }
		public static Vector4Int zyyz(this Vector2Int v, float z         ) { return new Vector4Int(  z, v.y, v.y,   z); }
		public static Vector4Int zyyw(this Vector2Int v, float z, float w) { return new Vector4Int(  z, v.y, v.y,   w); }
		public static Vector4Int zyzx(this Vector2Int v, float z         ) { return new Vector4Int(  z, v.y,   z, v.x); }
		public static Vector4Int zyzy(this Vector2Int v, float z         ) { return new Vector4Int(  z, v.y,   z, v.y); }
		public static Vector4Int zyzz(this Vector2Int v, float z         ) { return new Vector4Int(  z, v.y,   z,   z); }
		public static Vector4Int zyzw(this Vector2Int v, float z, float w) { return new Vector4Int(  z, v.y,   z,   w); }
		public static Vector4Int zywx(this Vector2Int v, float z, float w) { return new Vector4Int(  z, v.y,   w, v.x); }
		public static Vector4Int zywy(this Vector2Int v, float z, float w) { return new Vector4Int(  z, v.y,   w, v.y); }
		public static Vector4Int zywz(this Vector2Int v, float z, float w) { return new Vector4Int(  z, v.y,   w,   z); }
		public static Vector4Int zyww(this Vector2Int v, float z, float w) { return new Vector4Int(  z, v.y,   w,   w); }
		public static Vector4Int zzxx(this Vector2Int v, float z         ) { return new Vector4Int(  z,   z, v.x, v.x); }
		public static Vector4Int zzxy(this Vector2Int v, float z         ) { return new Vector4Int(  z,   z, v.x, v.y); }
		public static Vector4Int zzxz(this Vector2Int v, float z         ) { return new Vector4Int(  z,   z, v.x,   z); }
		public static Vector4Int zzxw(this Vector2Int v, float z, float w) { return new Vector4Int(  z,   z, v.x,   w); }
		public static Vector4Int zzyx(this Vector2Int v, float z         ) { return new Vector4Int(  z,   z, v.y, v.x); }
		public static Vector4Int zzyy(this Vector2Int v, float z         ) { return new Vector4Int(  z,   z, v.y, v.y); }
		public static Vector4Int zzyz(this Vector2Int v, float z         ) { return new Vector4Int(  z,   z, v.y,   z); }
		public static Vector4Int zzyw(this Vector2Int v, float z, float w) { return new Vector4Int(  z,   z, v.y,   w); }
		public static Vector4Int zzzx(this Vector2Int v, float z         ) { return new Vector4Int(  z,   z,   z, v.x); }
		public static Vector4Int zzzy(this Vector2Int v, float z         ) { return new Vector4Int(  z,   z,   z, v.y); }
		public static Vector4Int zzzz(this Vector2Int v, float z         ) { return new Vector4Int(  z,   z,   z,   z); }
		public static Vector4Int zzzw(this Vector2Int v, float z, float w) { return new Vector4Int(  z,   z,   z,   w); }
		public static Vector4Int zzwx(this Vector2Int v, float z, float w) { return new Vector4Int(  z,   z,   w, v.x); }
		public static Vector4Int zzwy(this Vector2Int v, float z, float w) { return new Vector4Int(  z,   z,   w, v.y); }
		public static Vector4Int zzwz(this Vector2Int v, float z, float w) { return new Vector4Int(  z,   z,   w,   z); }
		public static Vector4Int zzww(this Vector2Int v, float z, float w) { return new Vector4Int(  z,   z,   w,   w); }
		public static Vector4Int zwxx(this Vector2Int v, float z, float w) { return new Vector4Int(  z,   w, v.x, v.x); }
		public static Vector4Int zwxy(this Vector2Int v, float z, float w) { return new Vector4Int(  z,   w, v.x, v.y); }
		public static Vector4Int zwxz(this Vector2Int v, float z, float w) { return new Vector4Int(  z,   w, v.x,   z); }
		public static Vector4Int zwxw(this Vector2Int v, float z, float w) { return new Vector4Int(  z,   w, v.x,   w); }
		public static Vector4Int zwyx(this Vector2Int v, float z, float w) { return new Vector4Int(  z,   w, v.y, v.x); }
		public static Vector4Int zwyy(this Vector2Int v, float z, float w) { return new Vector4Int(  z,   w, v.y, v.y); }
		public static Vector4Int zwyz(this Vector2Int v, float z, float w) { return new Vector4Int(  z,   w, v.y,   z); }
		public static Vector4Int zwyw(this Vector2Int v, float z, float w) { return new Vector4Int(  z,   w, v.y,   w); }
		public static Vector4Int zwzx(this Vector2Int v, float z, float w) { return new Vector4Int(  z,   w,   z, v.x); }
		public static Vector4Int zwzy(this Vector2Int v, float z, float w) { return new Vector4Int(  z,   w,   z, v.y); }
		public static Vector4Int zwzz(this Vector2Int v, float z, float w) { return new Vector4Int(  z,   w,   z,   z); }
		public static Vector4Int zwzw(this Vector2Int v, float z, float w) { return new Vector4Int(  z,   w,   z,   w); }
		public static Vector4Int zwwx(this Vector2Int v, float z, float w) { return new Vector4Int(  z,   w,   w, v.x); }
		public static Vector4Int zwwy(this Vector2Int v, float z, float w) { return new Vector4Int(  z,   w,   w, v.y); }
		public static Vector4Int zwwz(this Vector2Int v, float z, float w) { return new Vector4Int(  z,   w,   w,   z); }
		public static Vector4Int zwww(this Vector2Int v, float z, float w) { return new Vector4Int(  z,   w,   w,   w); }
		public static Vector4Int wxxx(this Vector2Int v, float w         ) { return new Vector4Int(  w, v.x, v.x, v.x); }
		public static Vector4Int wxxy(this Vector2Int v, float w         ) { return new Vector4Int(  w, v.x, v.x, v.y); }
		public static Vector4Int wxxz(this Vector2Int v, float z, float w) { return new Vector4Int(  w, v.x, v.x,   z); }
		public static Vector4Int wxxw(this Vector2Int v, float w         ) { return new Vector4Int(  w, v.x, v.x,   w); }
		public static Vector4Int wxyx(this Vector2Int v, float w         ) { return new Vector4Int(  w, v.x, v.y, v.x); }
		public static Vector4Int wxyy(this Vector2Int v, float w         ) { return new Vector4Int(  w, v.x, v.y, v.y); }
		public static Vector4Int wxyz(this Vector2Int v, float z, float w) { return new Vector4Int(  w, v.x, v.y,   z); }
		public static Vector4Int wxyw(this Vector2Int v, float w         ) { return new Vector4Int(  w, v.x, v.y,   w); }
		public static Vector4Int wxzx(this Vector2Int v, float z, float w) { return new Vector4Int(  w, v.x,   z, v.x); }
		public static Vector4Int wxzy(this Vector2Int v, float z, float w) { return new Vector4Int(  w, v.x,   z, v.y); }
		public static Vector4Int wxzz(this Vector2Int v, float z, float w) { return new Vector4Int(  w, v.x,   z,   z); }
		public static Vector4Int wxzw(this Vector2Int v, float z, float w) { return new Vector4Int(  w, v.x,   z,   w); }
		public static Vector4Int wxwx(this Vector2Int v, float w         ) { return new Vector4Int(  w, v.x,   w, v.x); }
		public static Vector4Int wxwy(this Vector2Int v, float w         ) { return new Vector4Int(  w, v.x,   w, v.y); }
		public static Vector4Int wxwz(this Vector2Int v, float z, float w) { return new Vector4Int(  w, v.x,   w,   z); }
		public static Vector4Int wxww(this Vector2Int v, float w         ) { return new Vector4Int(  w, v.x,   w,   w); }
		public static Vector4Int wyxx(this Vector2Int v, float w         ) { return new Vector4Int(  w, v.y, v.x, v.x); }
		public static Vector4Int wyxy(this Vector2Int v, float w         ) { return new Vector4Int(  w, v.y, v.x, v.y); }
		public static Vector4Int wyxz(this Vector2Int v, float z, float w) { return new Vector4Int(  w, v.y, v.x,   z); }
		public static Vector4Int wyxw(this Vector2Int v, float w         ) { return new Vector4Int(  w, v.y, v.x,   w); }
		public static Vector4Int wyyx(this Vector2Int v, float w         ) { return new Vector4Int(  w, v.y, v.y, v.x); }
		public static Vector4Int wyyy(this Vector2Int v, float w         ) { return new Vector4Int(  w, v.y, v.y, v.y); }
		public static Vector4Int wyyz(this Vector2Int v, float z, float w) { return new Vector4Int(  w, v.y, v.y,   z); }
		public static Vector4Int wyyw(this Vector2Int v, float w         ) { return new Vector4Int(  w, v.y, v.y,   w); }
		public static Vector4Int wyzx(this Vector2Int v, float z, float w) { return new Vector4Int(  w, v.y,   z, v.x); }
		public static Vector4Int wyzy(this Vector2Int v, float z, float w) { return new Vector4Int(  w, v.y,   z, v.y); }
		public static Vector4Int wyzz(this Vector2Int v, float z, float w) { return new Vector4Int(  w, v.y,   z,   z); }
		public static Vector4Int wyzw(this Vector2Int v, float z, float w) { return new Vector4Int(  w, v.y,   z,   w); }
		public static Vector4Int wywx(this Vector2Int v, float w         ) { return new Vector4Int(  w, v.y,   w, v.x); }
		public static Vector4Int wywy(this Vector2Int v, float w         ) { return new Vector4Int(  w, v.y,   w, v.y); }
		public static Vector4Int wywz(this Vector2Int v, float z, float w) { return new Vector4Int(  w, v.y,   w,   z); }
		public static Vector4Int wyww(this Vector2Int v, float w         ) { return new Vector4Int(  w, v.y,   w,   w); }
		public static Vector4Int wzxx(this Vector2Int v, float z, float w) { return new Vector4Int(  w,   z, v.x, v.x); }
		public static Vector4Int wzxy(this Vector2Int v, float z, float w) { return new Vector4Int(  w,   z, v.x, v.y); }
		public static Vector4Int wzxz(this Vector2Int v, float z, float w) { return new Vector4Int(  w,   z, v.x,   z); }
		public static Vector4Int wzxw(this Vector2Int v, float z, float w) { return new Vector4Int(  w,   z, v.x,   w); }
		public static Vector4Int wzyx(this Vector2Int v, float z, float w) { return new Vector4Int(  w,   z, v.y, v.x); }
		public static Vector4Int wzyy(this Vector2Int v, float z, float w) { return new Vector4Int(  w,   z, v.y, v.y); }
		public static Vector4Int wzyz(this Vector2Int v, float z, float w) { return new Vector4Int(  w,   z, v.y,   z); }
		public static Vector4Int wzyw(this Vector2Int v, float z, float w) { return new Vector4Int(  w,   z, v.y,   w); }
		public static Vector4Int wzzx(this Vector2Int v, float z, float w) { return new Vector4Int(  w,   z,   z, v.x); }
		public static Vector4Int wzzy(this Vector2Int v, float z, float w) { return new Vector4Int(  w,   z,   z, v.y); }
		public static Vector4Int wzzz(this Vector2Int v, float z, float w) { return new Vector4Int(  w,   z,   z,   z); }
		public static Vector4Int wzzw(this Vector2Int v, float z, float w) { return new Vector4Int(  w,   z,   z,   w); }
		public static Vector4Int wzwx(this Vector2Int v, float z, float w) { return new Vector4Int(  w,   z,   w, v.x); }
		public static Vector4Int wzwy(this Vector2Int v, float z, float w) { return new Vector4Int(  w,   z,   w, v.y); }
		public static Vector4Int wzwz(this Vector2Int v, float z, float w) { return new Vector4Int(  w,   z,   w,   z); }
		public static Vector4Int wzww(this Vector2Int v, float z, float w) { return new Vector4Int(  w,   z,   w,   w); }
		public static Vector4Int wwxx(this Vector2Int v, float w         ) { return new Vector4Int(  w,   w, v.x, v.x); }
		public static Vector4Int wwxy(this Vector2Int v, float w         ) { return new Vector4Int(  w,   w, v.x, v.y); }
		public static Vector4Int wwxz(this Vector2Int v, float z, float w) { return new Vector4Int(  w,   w, v.x,   z); }
		public static Vector4Int wwxw(this Vector2Int v, float w         ) { return new Vector4Int(  w,   w, v.x,   w); }
		public static Vector4Int wwyx(this Vector2Int v, float w         ) { return new Vector4Int(  w,   w, v.y, v.x); }
		public static Vector4Int wwyy(this Vector2Int v, float w         ) { return new Vector4Int(  w,   w, v.y, v.y); }
		public static Vector4Int wwyz(this Vector2Int v, float z, float w) { return new Vector4Int(  w,   w, v.y,   z); }
		public static Vector4Int wwyw(this Vector2Int v, float w         ) { return new Vector4Int(  w,   w, v.y,   w); }
		public static Vector4Int wwzx(this Vector2Int v, float z, float w) { return new Vector4Int(  w,   w,   z, v.x); }
		public static Vector4Int wwzy(this Vector2Int v, float z, float w) { return new Vector4Int(  w,   w,   z, v.y); }
		public static Vector4Int wwzz(this Vector2Int v, float z, float w) { return new Vector4Int(  w,   w,   z,   z); }
		public static Vector4Int wwzw(this Vector2Int v, float z, float w) { return new Vector4Int(  w,   w,   z,   w); }
		public static Vector4Int wwwx(this Vector2Int v, float w         ) { return new Vector4Int(  w,   w,   w, v.x); }
		public static Vector4Int wwwy(this Vector2Int v, float w         ) { return new Vector4Int(  w,   w,   w, v.y); }
		public static Vector4Int wwwz(this Vector2Int v, float z, float w) { return new Vector4Int(  w,   w,   w,   z); }
		public static Vector4Int wwww(this Vector2Int v, float w         ) { return new Vector4Int(  w,   w,   w,   w); }
	}


	public static class SwizzleVector3IntTo4Int
	{
		public static Vector4Int xxxx(this Vector3Int v         ) { return new Vector4Int(v.x, v.x, v.x, v.x); }
		public static Vector4Int xxxy(this Vector3Int v         ) { return new Vector4Int(v.x, v.x, v.x, v.y); }
		public static Vector4Int xxxz(this Vector3Int v         ) { return new Vector4Int(v.x, v.x, v.x, v.z); }
		public static Vector4Int xxxw(this Vector3Int v, float w) { return new Vector4Int(v.x, v.x, v.x,   w); }
		public static Vector4Int xxyx(this Vector3Int v         ) { return new Vector4Int(v.x, v.x, v.y, v.x); }
		public static Vector4Int xxyy(this Vector3Int v         ) { return new Vector4Int(v.x, v.x, v.y, v.y); }
		public static Vector4Int xxyz(this Vector3Int v         ) { return new Vector4Int(v.x, v.x, v.y, v.z); }
		public static Vector4Int xxyw(this Vector3Int v, float w) { return new Vector4Int(v.x, v.x, v.y,   w); }
		public static Vector4Int xxzx(this Vector3Int v         ) { return new Vector4Int(v.x, v.x, v.z, v.x); }
		public static Vector4Int xxzy(this Vector3Int v         ) { return new Vector4Int(v.x, v.x, v.z, v.y); }
		public static Vector4Int xxzz(this Vector3Int v         ) { return new Vector4Int(v.x, v.x, v.z, v.z); }
		public static Vector4Int xxzw(this Vector3Int v, float w) { return new Vector4Int(v.x, v.x, v.z,   w); }
		public static Vector4Int xxwx(this Vector3Int v, float w) { return new Vector4Int(v.x, v.x,   w, v.x); }
		public static Vector4Int xxwy(this Vector3Int v, float w) { return new Vector4Int(v.x, v.x,   w, v.y); }
		public static Vector4Int xxwz(this Vector3Int v, float w) { return new Vector4Int(v.x, v.x,   w, v.z); }
		public static Vector4Int xxww(this Vector3Int v, float w) { return new Vector4Int(v.x, v.x,   w,   w); }
		public static Vector4Int xyxx(this Vector3Int v         ) { return new Vector4Int(v.x, v.y, v.x, v.x); }
		public static Vector4Int xyxy(this Vector3Int v         ) { return new Vector4Int(v.x, v.y, v.x, v.y); }
		public static Vector4Int xyxz(this Vector3Int v         ) { return new Vector4Int(v.x, v.y, v.x, v.z); }
		public static Vector4Int xyxw(this Vector3Int v, float w) { return new Vector4Int(v.x, v.y, v.x,   w); }
		public static Vector4Int xyyx(this Vector3Int v         ) { return new Vector4Int(v.x, v.y, v.y, v.x); }
		public static Vector4Int xyyy(this Vector3Int v         ) { return new Vector4Int(v.x, v.y, v.y, v.y); }
		public static Vector4Int xyyz(this Vector3Int v         ) { return new Vector4Int(v.x, v.y, v.y, v.z); }
		public static Vector4Int xyyw(this Vector3Int v, float w) { return new Vector4Int(v.x, v.y, v.y,   w); }
		public static Vector4Int xyzx(this Vector3Int v         ) { return new Vector4Int(v.x, v.y, v.z, v.x); }
		public static Vector4Int xyzy(this Vector3Int v         ) { return new Vector4Int(v.x, v.y, v.z, v.y); }
		public static Vector4Int xyzz(this Vector3Int v         ) { return new Vector4Int(v.x, v.y, v.z, v.z); }
		public static Vector4Int xyzw(this Vector3Int v, float w) { return new Vector4Int(v.x, v.y, v.z,   w); }
		public static Vector4Int xywx(this Vector3Int v, float w) { return new Vector4Int(v.x, v.y,   w, v.x); }
		public static Vector4Int xywy(this Vector3Int v, float w) { return new Vector4Int(v.x, v.y,   w, v.y); }
		public static Vector4Int xywz(this Vector3Int v, float w) { return new Vector4Int(v.x, v.y,   w, v.z); }
		public static Vector4Int xyww(this Vector3Int v, float w) { return new Vector4Int(v.x, v.y,   w,   w); }
		public static Vector4Int xzxx(this Vector3Int v         ) { return new Vector4Int(v.x, v.z, v.x, v.x); }
		public static Vector4Int xzxy(this Vector3Int v         ) { return new Vector4Int(v.x, v.z, v.x, v.y); }
		public static Vector4Int xzxz(this Vector3Int v         ) { return new Vector4Int(v.x, v.z, v.x, v.z); }
		public static Vector4Int xzxw(this Vector3Int v, float w) { return new Vector4Int(v.x, v.z, v.x,   w); }
		public static Vector4Int xzyx(this Vector3Int v         ) { return new Vector4Int(v.x, v.z, v.y, v.x); }
		public static Vector4Int xzyy(this Vector3Int v         ) { return new Vector4Int(v.x, v.z, v.y, v.y); }
		public static Vector4Int xzyz(this Vector3Int v         ) { return new Vector4Int(v.x, v.z, v.y, v.z); }
		public static Vector4Int xzyw(this Vector3Int v, float w) { return new Vector4Int(v.x, v.z, v.y,   w); }
		public static Vector4Int xzzx(this Vector3Int v         ) { return new Vector4Int(v.x, v.z, v.z, v.x); }
		public static Vector4Int xzzy(this Vector3Int v         ) { return new Vector4Int(v.x, v.z, v.z, v.y); }
		public static Vector4Int xzzz(this Vector3Int v         ) { return new Vector4Int(v.x, v.z, v.z, v.z); }
		public static Vector4Int xzzw(this Vector3Int v, float w) { return new Vector4Int(v.x, v.z, v.z,   w); }
		public static Vector4Int xzwx(this Vector3Int v, float w) { return new Vector4Int(v.x, v.z,   w, v.x); }
		public static Vector4Int xzwy(this Vector3Int v, float w) { return new Vector4Int(v.x, v.z,   w, v.y); }
		public static Vector4Int xzwz(this Vector3Int v, float w) { return new Vector4Int(v.x, v.z,   w, v.z); }
		public static Vector4Int xzww(this Vector3Int v, float w) { return new Vector4Int(v.x, v.z,   w,   w); }
		public static Vector4Int xwxx(this Vector3Int v, float w) { return new Vector4Int(v.x,   w, v.x, v.x); }
		public static Vector4Int xwxy(this Vector3Int v, float w) { return new Vector4Int(v.x,   w, v.x, v.y); }
		public static Vector4Int xwxz(this Vector3Int v, float w) { return new Vector4Int(v.x,   w, v.x, v.z); }
		public static Vector4Int xwxw(this Vector3Int v, float w) { return new Vector4Int(v.x,   w, v.x,   w); }
		public static Vector4Int xwyx(this Vector3Int v, float w) { return new Vector4Int(v.x,   w, v.y, v.x); }
		public static Vector4Int xwyy(this Vector3Int v, float w) { return new Vector4Int(v.x,   w, v.y, v.y); }
		public static Vector4Int xwyz(this Vector3Int v, float w) { return new Vector4Int(v.x,   w, v.y, v.z); }
		public static Vector4Int xwyw(this Vector3Int v, float w) { return new Vector4Int(v.x,   w, v.y,   w); }
		public static Vector4Int xwzx(this Vector3Int v, float w) { return new Vector4Int(v.x,   w, v.z, v.x); }
		public static Vector4Int xwzy(this Vector3Int v, float w) { return new Vector4Int(v.x,   w, v.z, v.y); }
		public static Vector4Int xwzz(this Vector3Int v, float w) { return new Vector4Int(v.x,   w, v.z, v.z); }
		public static Vector4Int xwzw(this Vector3Int v, float w) { return new Vector4Int(v.x,   w, v.z,   w); }
		public static Vector4Int xwwx(this Vector3Int v, float w) { return new Vector4Int(v.x,   w,   w, v.x); }
		public static Vector4Int xwwy(this Vector3Int v, float w) { return new Vector4Int(v.x,   w,   w, v.y); }
		public static Vector4Int xwwz(this Vector3Int v, float w) { return new Vector4Int(v.x,   w,   w, v.z); }
		public static Vector4Int xwww(this Vector3Int v, float w) { return new Vector4Int(v.x,   w,   w,   w); }
		public static Vector4Int yxxx(this Vector3Int v         ) { return new Vector4Int(v.y, v.x, v.x, v.x); }
		public static Vector4Int yxxy(this Vector3Int v         ) { return new Vector4Int(v.y, v.x, v.x, v.y); }
		public static Vector4Int yxxz(this Vector3Int v         ) { return new Vector4Int(v.y, v.x, v.x, v.z); }
		public static Vector4Int yxxw(this Vector3Int v, float w) { return new Vector4Int(v.y, v.x, v.x,   w); }
		public static Vector4Int yxyx(this Vector3Int v         ) { return new Vector4Int(v.y, v.x, v.y, v.x); }
		public static Vector4Int yxyy(this Vector3Int v         ) { return new Vector4Int(v.y, v.x, v.y, v.y); }
		public static Vector4Int yxyz(this Vector3Int v         ) { return new Vector4Int(v.y, v.x, v.y, v.z); }
		public static Vector4Int yxyw(this Vector3Int v, float w) { return new Vector4Int(v.y, v.x, v.y,   w); }
		public static Vector4Int yxzx(this Vector3Int v         ) { return new Vector4Int(v.y, v.x, v.z, v.x); }
		public static Vector4Int yxzy(this Vector3Int v         ) { return new Vector4Int(v.y, v.x, v.z, v.y); }
		public static Vector4Int yxzz(this Vector3Int v         ) { return new Vector4Int(v.y, v.x, v.z, v.z); }
		public static Vector4Int yxzw(this Vector3Int v, float w) { return new Vector4Int(v.y, v.x, v.z,   w); }
		public static Vector4Int yxwx(this Vector3Int v, float w) { return new Vector4Int(v.y, v.x,   w, v.x); }
		public static Vector4Int yxwy(this Vector3Int v, float w) { return new Vector4Int(v.y, v.x,   w, v.y); }
		public static Vector4Int yxwz(this Vector3Int v, float w) { return new Vector4Int(v.y, v.x,   w, v.z); }
		public static Vector4Int yxww(this Vector3Int v, float w) { return new Vector4Int(v.y, v.x,   w,   w); }
		public static Vector4Int yyxx(this Vector3Int v         ) { return new Vector4Int(v.y, v.y, v.x, v.x); }
		public static Vector4Int yyxy(this Vector3Int v         ) { return new Vector4Int(v.y, v.y, v.x, v.y); }
		public static Vector4Int yyxz(this Vector3Int v         ) { return new Vector4Int(v.y, v.y, v.x, v.z); }
		public static Vector4Int yyxw(this Vector3Int v, float w) { return new Vector4Int(v.y, v.y, v.x,   w); }
		public static Vector4Int yyyx(this Vector3Int v         ) { return new Vector4Int(v.y, v.y, v.y, v.x); }
		public static Vector4Int yyyy(this Vector3Int v         ) { return new Vector4Int(v.y, v.y, v.y, v.y); }
		public static Vector4Int yyyz(this Vector3Int v         ) { return new Vector4Int(v.y, v.y, v.y, v.z); }
		public static Vector4Int yyyw(this Vector3Int v, float w) { return new Vector4Int(v.y, v.y, v.y,   w); }
		public static Vector4Int yyzx(this Vector3Int v         ) { return new Vector4Int(v.y, v.y, v.z, v.x); }
		public static Vector4Int yyzy(this Vector3Int v         ) { return new Vector4Int(v.y, v.y, v.z, v.y); }
		public static Vector4Int yyzz(this Vector3Int v         ) { return new Vector4Int(v.y, v.y, v.z, v.z); }
		public static Vector4Int yyzw(this Vector3Int v, float w) { return new Vector4Int(v.y, v.y, v.z,   w); }
		public static Vector4Int yywx(this Vector3Int v, float w) { return new Vector4Int(v.y, v.y,   w, v.x); }
		public static Vector4Int yywy(this Vector3Int v, float w) { return new Vector4Int(v.y, v.y,   w, v.y); }
		public static Vector4Int yywz(this Vector3Int v, float w) { return new Vector4Int(v.y, v.y,   w, v.z); }
		public static Vector4Int yyww(this Vector3Int v, float w) { return new Vector4Int(v.y, v.y,   w,   w); }
		public static Vector4Int yzxx(this Vector3Int v         ) { return new Vector4Int(v.y, v.z, v.x, v.x); }
		public static Vector4Int yzxy(this Vector3Int v         ) { return new Vector4Int(v.y, v.z, v.x, v.y); }
		public static Vector4Int yzxz(this Vector3Int v         ) { return new Vector4Int(v.y, v.z, v.x, v.z); }
		public static Vector4Int yzxw(this Vector3Int v, float w) { return new Vector4Int(v.y, v.z, v.x,   w); }
		public static Vector4Int yzyx(this Vector3Int v         ) { return new Vector4Int(v.y, v.z, v.y, v.x); }
		public static Vector4Int yzyy(this Vector3Int v         ) { return new Vector4Int(v.y, v.z, v.y, v.y); }
		public static Vector4Int yzyz(this Vector3Int v         ) { return new Vector4Int(v.y, v.z, v.y, v.z); }
		public static Vector4Int yzyw(this Vector3Int v, float w) { return new Vector4Int(v.y, v.z, v.y,   w); }
		public static Vector4Int yzzx(this Vector3Int v         ) { return new Vector4Int(v.y, v.z, v.z, v.x); }
		public static Vector4Int yzzy(this Vector3Int v         ) { return new Vector4Int(v.y, v.z, v.z, v.y); }
		public static Vector4Int yzzz(this Vector3Int v         ) { return new Vector4Int(v.y, v.z, v.z, v.z); }
		public static Vector4Int yzzw(this Vector3Int v, float w) { return new Vector4Int(v.y, v.z, v.z,   w); }
		public static Vector4Int yzwx(this Vector3Int v, float w) { return new Vector4Int(v.y, v.z,   w, v.x); }
		public static Vector4Int yzwy(this Vector3Int v, float w) { return new Vector4Int(v.y, v.z,   w, v.y); }
		public static Vector4Int yzwz(this Vector3Int v, float w) { return new Vector4Int(v.y, v.z,   w, v.z); }
		public static Vector4Int yzww(this Vector3Int v, float w) { return new Vector4Int(v.y, v.z,   w,   w); }
		public static Vector4Int ywxx(this Vector3Int v, float w) { return new Vector4Int(v.y,   w, v.x, v.x); }
		public static Vector4Int ywxy(this Vector3Int v, float w) { return new Vector4Int(v.y,   w, v.x, v.y); }
		public static Vector4Int ywxz(this Vector3Int v, float w) { return new Vector4Int(v.y,   w, v.x, v.z); }
		public static Vector4Int ywxw(this Vector3Int v, float w) { return new Vector4Int(v.y,   w, v.x,   w); }
		public static Vector4Int ywyx(this Vector3Int v, float w) { return new Vector4Int(v.y,   w, v.y, v.x); }
		public static Vector4Int ywyy(this Vector3Int v, float w) { return new Vector4Int(v.y,   w, v.y, v.y); }
		public static Vector4Int ywyz(this Vector3Int v, float w) { return new Vector4Int(v.y,   w, v.y, v.z); }
		public static Vector4Int ywyw(this Vector3Int v, float w) { return new Vector4Int(v.y,   w, v.y,   w); }
		public static Vector4Int ywzx(this Vector3Int v, float w) { return new Vector4Int(v.y,   w, v.z, v.x); }
		public static Vector4Int ywzy(this Vector3Int v, float w) { return new Vector4Int(v.y,   w, v.z, v.y); }
		public static Vector4Int ywzz(this Vector3Int v, float w) { return new Vector4Int(v.y,   w, v.z, v.z); }
		public static Vector4Int ywzw(this Vector3Int v, float w) { return new Vector4Int(v.y,   w, v.z,   w); }
		public static Vector4Int ywwx(this Vector3Int v, float w) { return new Vector4Int(v.y,   w,   w, v.x); }
		public static Vector4Int ywwy(this Vector3Int v, float w) { return new Vector4Int(v.y,   w,   w, v.y); }
		public static Vector4Int ywwz(this Vector3Int v, float w) { return new Vector4Int(v.y,   w,   w, v.z); }
		public static Vector4Int ywww(this Vector3Int v, float w) { return new Vector4Int(v.y,   w,   w,   w); }
		public static Vector4Int zxxx(this Vector3Int v         ) { return new Vector4Int(v.z, v.x, v.x, v.x); }
		public static Vector4Int zxxy(this Vector3Int v         ) { return new Vector4Int(v.z, v.x, v.x, v.y); }
		public static Vector4Int zxxz(this Vector3Int v         ) { return new Vector4Int(v.z, v.x, v.x, v.z); }
		public static Vector4Int zxxw(this Vector3Int v, float w) { return new Vector4Int(v.z, v.x, v.x,   w); }
		public static Vector4Int zxyx(this Vector3Int v         ) { return new Vector4Int(v.z, v.x, v.y, v.x); }
		public static Vector4Int zxyy(this Vector3Int v         ) { return new Vector4Int(v.z, v.x, v.y, v.y); }
		public static Vector4Int zxyz(this Vector3Int v         ) { return new Vector4Int(v.z, v.x, v.y, v.z); }
		public static Vector4Int zxyw(this Vector3Int v, float w) { return new Vector4Int(v.z, v.x, v.y,   w); }
		public static Vector4Int zxzx(this Vector3Int v         ) { return new Vector4Int(v.z, v.x, v.z, v.x); }
		public static Vector4Int zxzy(this Vector3Int v         ) { return new Vector4Int(v.z, v.x, v.z, v.y); }
		public static Vector4Int zxzz(this Vector3Int v         ) { return new Vector4Int(v.z, v.x, v.z, v.z); }
		public static Vector4Int zxzw(this Vector3Int v, float w) { return new Vector4Int(v.z, v.x, v.z,   w); }
		public static Vector4Int zxwx(this Vector3Int v, float w) { return new Vector4Int(v.z, v.x,   w, v.x); }
		public static Vector4Int zxwy(this Vector3Int v, float w) { return new Vector4Int(v.z, v.x,   w, v.y); }
		public static Vector4Int zxwz(this Vector3Int v, float w) { return new Vector4Int(v.z, v.x,   w, v.z); }
		public static Vector4Int zxww(this Vector3Int v, float w) { return new Vector4Int(v.z, v.x,   w,   w); }
		public static Vector4Int zyxx(this Vector3Int v         ) { return new Vector4Int(v.z, v.y, v.x, v.x); }
		public static Vector4Int zyxy(this Vector3Int v         ) { return new Vector4Int(v.z, v.y, v.x, v.y); }
		public static Vector4Int zyxz(this Vector3Int v         ) { return new Vector4Int(v.z, v.y, v.x, v.z); }
		public static Vector4Int zyxw(this Vector3Int v, float w) { return new Vector4Int(v.z, v.y, v.x,   w); }
		public static Vector4Int zyyx(this Vector3Int v         ) { return new Vector4Int(v.z, v.y, v.y, v.x); }
		public static Vector4Int zyyy(this Vector3Int v         ) { return new Vector4Int(v.z, v.y, v.y, v.y); }
		public static Vector4Int zyyz(this Vector3Int v         ) { return new Vector4Int(v.z, v.y, v.y, v.z); }
		public static Vector4Int zyyw(this Vector3Int v, float w) { return new Vector4Int(v.z, v.y, v.y,   w); }
		public static Vector4Int zyzx(this Vector3Int v         ) { return new Vector4Int(v.z, v.y, v.z, v.x); }
		public static Vector4Int zyzy(this Vector3Int v         ) { return new Vector4Int(v.z, v.y, v.z, v.y); }
		public static Vector4Int zyzz(this Vector3Int v         ) { return new Vector4Int(v.z, v.y, v.z, v.z); }
		public static Vector4Int zyzw(this Vector3Int v, float w) { return new Vector4Int(v.z, v.y, v.z,   w); }
		public static Vector4Int zywx(this Vector3Int v, float w) { return new Vector4Int(v.z, v.y,   w, v.x); }
		public static Vector4Int zywy(this Vector3Int v, float w) { return new Vector4Int(v.z, v.y,   w, v.y); }
		public static Vector4Int zywz(this Vector3Int v, float w) { return new Vector4Int(v.z, v.y,   w, v.z); }
		public static Vector4Int zyww(this Vector3Int v, float w) { return new Vector4Int(v.z, v.y,   w,   w); }
		public static Vector4Int zzxx(this Vector3Int v         ) { return new Vector4Int(v.z, v.z, v.x, v.x); }
		public static Vector4Int zzxy(this Vector3Int v         ) { return new Vector4Int(v.z, v.z, v.x, v.y); }
		public static Vector4Int zzxz(this Vector3Int v         ) { return new Vector4Int(v.z, v.z, v.x, v.z); }
		public static Vector4Int zzxw(this Vector3Int v, float w) { return new Vector4Int(v.z, v.z, v.x,   w); }
		public static Vector4Int zzyx(this Vector3Int v         ) { return new Vector4Int(v.z, v.z, v.y, v.x); }
		public static Vector4Int zzyy(this Vector3Int v         ) { return new Vector4Int(v.z, v.z, v.y, v.y); }
		public static Vector4Int zzyz(this Vector3Int v         ) { return new Vector4Int(v.z, v.z, v.y, v.z); }
		public static Vector4Int zzyw(this Vector3Int v, float w) { return new Vector4Int(v.z, v.z, v.y,   w); }
		public static Vector4Int zzzx(this Vector3Int v         ) { return new Vector4Int(v.z, v.z, v.z, v.x); }
		public static Vector4Int zzzy(this Vector3Int v         ) { return new Vector4Int(v.z, v.z, v.z, v.y); }
		public static Vector4Int zzzz(this Vector3Int v         ) { return new Vector4Int(v.z, v.z, v.z, v.z); }
		public static Vector4Int zzzw(this Vector3Int v, float w) { return new Vector4Int(v.z, v.z, v.z,   w); }
		public static Vector4Int zzwx(this Vector3Int v, float w) { return new Vector4Int(v.z, v.z,   w, v.x); }
		public static Vector4Int zzwy(this Vector3Int v, float w) { return new Vector4Int(v.z, v.z,   w, v.y); }
		public static Vector4Int zzwz(this Vector3Int v, float w) { return new Vector4Int(v.z, v.z,   w, v.z); }
		public static Vector4Int zzww(this Vector3Int v, float w) { return new Vector4Int(v.z, v.z,   w,   w); }
		public static Vector4Int zwxx(this Vector3Int v, float w) { return new Vector4Int(v.z,   w, v.x, v.x); }
		public static Vector4Int zwxy(this Vector3Int v, float w) { return new Vector4Int(v.z,   w, v.x, v.y); }
		public static Vector4Int zwxz(this Vector3Int v, float w) { return new Vector4Int(v.z,   w, v.x, v.z); }
		public static Vector4Int zwxw(this Vector3Int v, float w) { return new Vector4Int(v.z,   w, v.x,   w); }
		public static Vector4Int zwyx(this Vector3Int v, float w) { return new Vector4Int(v.z,   w, v.y, v.x); }
		public static Vector4Int zwyy(this Vector3Int v, float w) { return new Vector4Int(v.z,   w, v.y, v.y); }
		public static Vector4Int zwyz(this Vector3Int v, float w) { return new Vector4Int(v.z,   w, v.y, v.z); }
		public static Vector4Int zwyw(this Vector3Int v, float w) { return new Vector4Int(v.z,   w, v.y,   w); }
		public static Vector4Int zwzx(this Vector3Int v, float w) { return new Vector4Int(v.z,   w, v.z, v.x); }
		public static Vector4Int zwzy(this Vector3Int v, float w) { return new Vector4Int(v.z,   w, v.z, v.y); }
		public static Vector4Int zwzz(this Vector3Int v, float w) { return new Vector4Int(v.z,   w, v.z, v.z); }
		public static Vector4Int zwzw(this Vector3Int v, float w) { return new Vector4Int(v.z,   w, v.z,   w); }
		public static Vector4Int zwwx(this Vector3Int v, float w) { return new Vector4Int(v.z,   w,   w, v.x); }
		public static Vector4Int zwwy(this Vector3Int v, float w) { return new Vector4Int(v.z,   w,   w, v.y); }
		public static Vector4Int zwwz(this Vector3Int v, float w) { return new Vector4Int(v.z,   w,   w, v.z); }
		public static Vector4Int zwww(this Vector3Int v, float w) { return new Vector4Int(v.z,   w,   w,   w); }
		public static Vector4Int wxxx(this Vector3Int v, float w) { return new Vector4Int(  w, v.x, v.x, v.x); }
		public static Vector4Int wxxy(this Vector3Int v, float w) { return new Vector4Int(  w, v.x, v.x, v.y); }
		public static Vector4Int wxxz(this Vector3Int v, float w) { return new Vector4Int(  w, v.x, v.x, v.z); }
		public static Vector4Int wxxw(this Vector3Int v, float w) { return new Vector4Int(  w, v.x, v.x,   w); }
		public static Vector4Int wxyx(this Vector3Int v, float w) { return new Vector4Int(  w, v.x, v.y, v.x); }
		public static Vector4Int wxyy(this Vector3Int v, float w) { return new Vector4Int(  w, v.x, v.y, v.y); }
		public static Vector4Int wxyz(this Vector3Int v, float w) { return new Vector4Int(  w, v.x, v.y, v.z); }
		public static Vector4Int wxyw(this Vector3Int v, float w) { return new Vector4Int(  w, v.x, v.y,   w); }
		public static Vector4Int wxzx(this Vector3Int v, float w) { return new Vector4Int(  w, v.x, v.z, v.x); }
		public static Vector4Int wxzy(this Vector3Int v, float w) { return new Vector4Int(  w, v.x, v.z, v.y); }
		public static Vector4Int wxzz(this Vector3Int v, float w) { return new Vector4Int(  w, v.x, v.z, v.z); }
		public static Vector4Int wxzw(this Vector3Int v, float w) { return new Vector4Int(  w, v.x, v.z,   w); }
		public static Vector4Int wxwx(this Vector3Int v, float w) { return new Vector4Int(  w, v.x,   w, v.x); }
		public static Vector4Int wxwy(this Vector3Int v, float w) { return new Vector4Int(  w, v.x,   w, v.y); }
		public static Vector4Int wxwz(this Vector3Int v, float w) { return new Vector4Int(  w, v.x,   w, v.z); }
		public static Vector4Int wxww(this Vector3Int v, float w) { return new Vector4Int(  w, v.x,   w,   w); }
		public static Vector4Int wyxx(this Vector3Int v, float w) { return new Vector4Int(  w, v.y, v.x, v.x); }
		public static Vector4Int wyxy(this Vector3Int v, float w) { return new Vector4Int(  w, v.y, v.x, v.y); }
		public static Vector4Int wyxz(this Vector3Int v, float w) { return new Vector4Int(  w, v.y, v.x, v.z); }
		public static Vector4Int wyxw(this Vector3Int v, float w) { return new Vector4Int(  w, v.y, v.x,   w); }
		public static Vector4Int wyyx(this Vector3Int v, float w) { return new Vector4Int(  w, v.y, v.y, v.x); }
		public static Vector4Int wyyy(this Vector3Int v, float w) { return new Vector4Int(  w, v.y, v.y, v.y); }
		public static Vector4Int wyyz(this Vector3Int v, float w) { return new Vector4Int(  w, v.y, v.y, v.z); }
		public static Vector4Int wyyw(this Vector3Int v, float w) { return new Vector4Int(  w, v.y, v.y,   w); }
		public static Vector4Int wyzx(this Vector3Int v, float w) { return new Vector4Int(  w, v.y, v.z, v.x); }
		public static Vector4Int wyzy(this Vector3Int v, float w) { return new Vector4Int(  w, v.y, v.z, v.y); }
		public static Vector4Int wyzz(this Vector3Int v, float w) { return new Vector4Int(  w, v.y, v.z, v.z); }
		public static Vector4Int wyzw(this Vector3Int v, float w) { return new Vector4Int(  w, v.y, v.z,   w); }
		public static Vector4Int wywx(this Vector3Int v, float w) { return new Vector4Int(  w, v.y,   w, v.x); }
		public static Vector4Int wywy(this Vector3Int v, float w) { return new Vector4Int(  w, v.y,   w, v.y); }
		public static Vector4Int wywz(this Vector3Int v, float w) { return new Vector4Int(  w, v.y,   w, v.z); }
		public static Vector4Int wyww(this Vector3Int v, float w) { return new Vector4Int(  w, v.y,   w,   w); }
		public static Vector4Int wzxx(this Vector3Int v, float w) { return new Vector4Int(  w, v.z, v.x, v.x); }
		public static Vector4Int wzxy(this Vector3Int v, float w) { return new Vector4Int(  w, v.z, v.x, v.y); }
		public static Vector4Int wzxz(this Vector3Int v, float w) { return new Vector4Int(  w, v.z, v.x, v.z); }
		public static Vector4Int wzxw(this Vector3Int v, float w) { return new Vector4Int(  w, v.z, v.x,   w); }
		public static Vector4Int wzyx(this Vector3Int v, float w) { return new Vector4Int(  w, v.z, v.y, v.x); }
		public static Vector4Int wzyy(this Vector3Int v, float w) { return new Vector4Int(  w, v.z, v.y, v.y); }
		public static Vector4Int wzyz(this Vector3Int v, float w) { return new Vector4Int(  w, v.z, v.y, v.z); }
		public static Vector4Int wzyw(this Vector3Int v, float w) { return new Vector4Int(  w, v.z, v.y,   w); }
		public static Vector4Int wzzx(this Vector3Int v, float w) { return new Vector4Int(  w, v.z, v.z, v.x); }
		public static Vector4Int wzzy(this Vector3Int v, float w) { return new Vector4Int(  w, v.z, v.z, v.y); }
		public static Vector4Int wzzz(this Vector3Int v, float w) { return new Vector4Int(  w, v.z, v.z, v.z); }
		public static Vector4Int wzzw(this Vector3Int v, float w) { return new Vector4Int(  w, v.z, v.z,   w); }
		public static Vector4Int wzwx(this Vector3Int v, float w) { return new Vector4Int(  w, v.z,   w, v.x); }
		public static Vector4Int wzwy(this Vector3Int v, float w) { return new Vector4Int(  w, v.z,   w, v.y); }
		public static Vector4Int wzwz(this Vector3Int v, float w) { return new Vector4Int(  w, v.z,   w, v.z); }
		public static Vector4Int wzww(this Vector3Int v, float w) { return new Vector4Int(  w, v.z,   w,   w); }
		public static Vector4Int wwxx(this Vector3Int v, float w) { return new Vector4Int(  w,   w, v.x, v.x); }
		public static Vector4Int wwxy(this Vector3Int v, float w) { return new Vector4Int(  w,   w, v.x, v.y); }
		public static Vector4Int wwxz(this Vector3Int v, float w) { return new Vector4Int(  w,   w, v.x, v.z); }
		public static Vector4Int wwxw(this Vector3Int v, float w) { return new Vector4Int(  w,   w, v.x,   w); }
		public static Vector4Int wwyx(this Vector3Int v, float w) { return new Vector4Int(  w,   w, v.y, v.x); }
		public static Vector4Int wwyy(this Vector3Int v, float w) { return new Vector4Int(  w,   w, v.y, v.y); }
		public static Vector4Int wwyz(this Vector3Int v, float w) { return new Vector4Int(  w,   w, v.y, v.z); }
		public static Vector4Int wwyw(this Vector3Int v, float w) { return new Vector4Int(  w,   w, v.y,   w); }
		public static Vector4Int wwzx(this Vector3Int v, float w) { return new Vector4Int(  w,   w, v.z, v.x); }
		public static Vector4Int wwzy(this Vector3Int v, float w) { return new Vector4Int(  w,   w, v.z, v.y); }
		public static Vector4Int wwzz(this Vector3Int v, float w) { return new Vector4Int(  w,   w, v.z, v.z); }
		public static Vector4Int wwzw(this Vector3Int v, float w) { return new Vector4Int(  w,   w, v.z,   w); }
		public static Vector4Int wwwx(this Vector3Int v, float w) { return new Vector4Int(  w,   w,   w, v.x); }
		public static Vector4Int wwwy(this Vector3Int v, float w) { return new Vector4Int(  w,   w,   w, v.y); }
		public static Vector4Int wwwz(this Vector3Int v, float w) { return new Vector4Int(  w,   w,   w, v.z); }
		public static Vector4Int wwww(this Vector3Int v, float w) { return new Vector4Int(  w,   w,   w,   w); }
	}


	public static class SwizzleVector4IntTo4Int
	{
		public static Vector4Int xxxx(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.x, v.x); }
		public static Vector4Int xxxy(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.x, v.y); }
		public static Vector4Int xxxz(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.x, v.z); }
		public static Vector4Int xxxw(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.x, v.w); }
		public static Vector4Int xxyx(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.y, v.x); }
		public static Vector4Int xxyy(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.y, v.y); }
		public static Vector4Int xxyz(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.y, v.z); }
		public static Vector4Int xxyw(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.y, v.w); }
		public static Vector4Int xxzx(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.z, v.x); }
		public static Vector4Int xxzy(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.z, v.y); }
		public static Vector4Int xxzz(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.z, v.z); }
		public static Vector4Int xxzw(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.z, v.w); }
		public static Vector4Int xxwx(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.w, v.x); }
		public static Vector4Int xxwy(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.w, v.y); }
		public static Vector4Int xxwz(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.w, v.z); }
		public static Vector4Int xxww(this Vector4Int v) { return new Vector4Int(v.x, v.x, v.w, v.w); }
		public static Vector4Int xyxx(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.x, v.x); }
		public static Vector4Int xyxy(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.x, v.y); }
		public static Vector4Int xyxz(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.x, v.z); }
		public static Vector4Int xyxw(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.x, v.w); }
		public static Vector4Int xyyx(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.y, v.x); }
		public static Vector4Int xyyy(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.y, v.y); }
		public static Vector4Int xyyz(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.y, v.z); }
		public static Vector4Int xyyw(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.y, v.w); }
		public static Vector4Int xyzx(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.z, v.x); }
		public static Vector4Int xyzy(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.z, v.y); }
		public static Vector4Int xyzz(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.z, v.z); }
		public static Vector4Int xyzw(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.z, v.w); }
		public static Vector4Int xywx(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.w, v.x); }
		public static Vector4Int xywy(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.w, v.y); }
		public static Vector4Int xywz(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.w, v.z); }
		public static Vector4Int xyww(this Vector4Int v) { return new Vector4Int(v.x, v.y, v.w, v.w); }
		public static Vector4Int xzxx(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.x, v.x); }
		public static Vector4Int xzxy(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.x, v.y); }
		public static Vector4Int xzxz(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.x, v.z); }
		public static Vector4Int xzxw(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.x, v.w); }
		public static Vector4Int xzyx(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.y, v.x); }
		public static Vector4Int xzyy(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.y, v.y); }
		public static Vector4Int xzyz(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.y, v.z); }
		public static Vector4Int xzyw(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.y, v.w); }
		public static Vector4Int xzzx(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.z, v.x); }
		public static Vector4Int xzzy(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.z, v.y); }
		public static Vector4Int xzzz(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.z, v.z); }
		public static Vector4Int xzzw(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.z, v.w); }
		public static Vector4Int xzwx(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.w, v.x); }
		public static Vector4Int xzwy(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.w, v.y); }
		public static Vector4Int xzwz(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.w, v.z); }
		public static Vector4Int xzww(this Vector4Int v) { return new Vector4Int(v.x, v.z, v.w, v.w); }
		public static Vector4Int xwxx(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.x, v.x); }
		public static Vector4Int xwxy(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.x, v.y); }
		public static Vector4Int xwxz(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.x, v.z); }
		public static Vector4Int xwxw(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.x, v.w); }
		public static Vector4Int xwyx(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.y, v.x); }
		public static Vector4Int xwyy(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.y, v.y); }
		public static Vector4Int xwyz(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.y, v.z); }
		public static Vector4Int xwyw(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.y, v.w); }
		public static Vector4Int xwzx(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.z, v.x); }
		public static Vector4Int xwzy(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.z, v.y); }
		public static Vector4Int xwzz(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.z, v.z); }
		public static Vector4Int xwzw(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.z, v.w); }
		public static Vector4Int xwwx(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.w, v.x); }
		public static Vector4Int xwwy(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.w, v.y); }
		public static Vector4Int xwwz(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.w, v.z); }
		public static Vector4Int xwww(this Vector4Int v) { return new Vector4Int(v.x, v.w, v.w, v.w); }
		public static Vector4Int yxxx(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.x, v.x); }
		public static Vector4Int yxxy(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.x, v.y); }
		public static Vector4Int yxxz(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.x, v.z); }
		public static Vector4Int yxxw(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.x, v.w); }
		public static Vector4Int yxyx(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.y, v.x); }
		public static Vector4Int yxyy(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.y, v.y); }
		public static Vector4Int yxyz(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.y, v.z); }
		public static Vector4Int yxyw(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.y, v.w); }
		public static Vector4Int yxzx(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.z, v.x); }
		public static Vector4Int yxzy(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.z, v.y); }
		public static Vector4Int yxzz(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.z, v.z); }
		public static Vector4Int yxzw(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.z, v.w); }
		public static Vector4Int yxwx(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.w, v.x); }
		public static Vector4Int yxwy(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.w, v.y); }
		public static Vector4Int yxwz(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.w, v.z); }
		public static Vector4Int yxww(this Vector4Int v) { return new Vector4Int(v.y, v.x, v.w, v.w); }
		public static Vector4Int yyxx(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.x, v.x); }
		public static Vector4Int yyxy(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.x, v.y); }
		public static Vector4Int yyxz(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.x, v.z); }
		public static Vector4Int yyxw(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.x, v.w); }
		public static Vector4Int yyyx(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.y, v.x); }
		public static Vector4Int yyyy(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.y, v.y); }
		public static Vector4Int yyyz(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.y, v.z); }
		public static Vector4Int yyyw(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.y, v.w); }
		public static Vector4Int yyzx(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.z, v.x); }
		public static Vector4Int yyzy(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.z, v.y); }
		public static Vector4Int yyzz(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.z, v.z); }
		public static Vector4Int yyzw(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.z, v.w); }
		public static Vector4Int yywx(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.w, v.x); }
		public static Vector4Int yywy(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.w, v.y); }
		public static Vector4Int yywz(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.w, v.z); }
		public static Vector4Int yyww(this Vector4Int v) { return new Vector4Int(v.y, v.y, v.w, v.w); }
		public static Vector4Int yzxx(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.x, v.x); }
		public static Vector4Int yzxy(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.x, v.y); }
		public static Vector4Int yzxz(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.x, v.z); }
		public static Vector4Int yzxw(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.x, v.w); }
		public static Vector4Int yzyx(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.y, v.x); }
		public static Vector4Int yzyy(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.y, v.y); }
		public static Vector4Int yzyz(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.y, v.z); }
		public static Vector4Int yzyw(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.y, v.w); }
		public static Vector4Int yzzx(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.z, v.x); }
		public static Vector4Int yzzy(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.z, v.y); }
		public static Vector4Int yzzz(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.z, v.z); }
		public static Vector4Int yzzw(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.z, v.w); }
		public static Vector4Int yzwx(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.w, v.x); }
		public static Vector4Int yzwy(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.w, v.y); }
		public static Vector4Int yzwz(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.w, v.z); }
		public static Vector4Int yzww(this Vector4Int v) { return new Vector4Int(v.y, v.z, v.w, v.w); }
		public static Vector4Int ywxx(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.x, v.x); }
		public static Vector4Int ywxy(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.x, v.y); }
		public static Vector4Int ywxz(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.x, v.z); }
		public static Vector4Int ywxw(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.x, v.w); }
		public static Vector4Int ywyx(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.y, v.x); }
		public static Vector4Int ywyy(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.y, v.y); }
		public static Vector4Int ywyz(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.y, v.z); }
		public static Vector4Int ywyw(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.y, v.w); }
		public static Vector4Int ywzx(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.z, v.x); }
		public static Vector4Int ywzy(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.z, v.y); }
		public static Vector4Int ywzz(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.z, v.z); }
		public static Vector4Int ywzw(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.z, v.w); }
		public static Vector4Int ywwx(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.w, v.x); }
		public static Vector4Int ywwy(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.w, v.y); }
		public static Vector4Int ywwz(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.w, v.z); }
		public static Vector4Int ywww(this Vector4Int v) { return new Vector4Int(v.y, v.w, v.w, v.w); }
		public static Vector4Int zxxx(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.x, v.x); }
		public static Vector4Int zxxy(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.x, v.y); }
		public static Vector4Int zxxz(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.x, v.z); }
		public static Vector4Int zxxw(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.x, v.w); }
		public static Vector4Int zxyx(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.y, v.x); }
		public static Vector4Int zxyy(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.y, v.y); }
		public static Vector4Int zxyz(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.y, v.z); }
		public static Vector4Int zxyw(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.y, v.w); }
		public static Vector4Int zxzx(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.z, v.x); }
		public static Vector4Int zxzy(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.z, v.y); }
		public static Vector4Int zxzz(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.z, v.z); }
		public static Vector4Int zxzw(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.z, v.w); }
		public static Vector4Int zxwx(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.w, v.x); }
		public static Vector4Int zxwy(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.w, v.y); }
		public static Vector4Int zxwz(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.w, v.z); }
		public static Vector4Int zxww(this Vector4Int v) { return new Vector4Int(v.z, v.x, v.w, v.w); }
		public static Vector4Int zyxx(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.x, v.x); }
		public static Vector4Int zyxy(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.x, v.y); }
		public static Vector4Int zyxz(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.x, v.z); }
		public static Vector4Int zyxw(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.x, v.w); }
		public static Vector4Int zyyx(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.y, v.x); }
		public static Vector4Int zyyy(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.y, v.y); }
		public static Vector4Int zyyz(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.y, v.z); }
		public static Vector4Int zyyw(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.y, v.w); }
		public static Vector4Int zyzx(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.z, v.x); }
		public static Vector4Int zyzy(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.z, v.y); }
		public static Vector4Int zyzz(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.z, v.z); }
		public static Vector4Int zyzw(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.z, v.w); }
		public static Vector4Int zywx(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.w, v.x); }
		public static Vector4Int zywy(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.w, v.y); }
		public static Vector4Int zywz(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.w, v.z); }
		public static Vector4Int zyww(this Vector4Int v) { return new Vector4Int(v.z, v.y, v.w, v.w); }
		public static Vector4Int zzxx(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.x, v.x); }
		public static Vector4Int zzxy(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.x, v.y); }
		public static Vector4Int zzxz(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.x, v.z); }
		public static Vector4Int zzxw(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.x, v.w); }
		public static Vector4Int zzyx(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.y, v.x); }
		public static Vector4Int zzyy(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.y, v.y); }
		public static Vector4Int zzyz(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.y, v.z); }
		public static Vector4Int zzyw(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.y, v.w); }
		public static Vector4Int zzzx(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.z, v.x); }
		public static Vector4Int zzzy(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.z, v.y); }
		public static Vector4Int zzzz(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.z, v.z); }
		public static Vector4Int zzzw(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.z, v.w); }
		public static Vector4Int zzwx(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.w, v.x); }
		public static Vector4Int zzwy(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.w, v.y); }
		public static Vector4Int zzwz(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.w, v.z); }
		public static Vector4Int zzww(this Vector4Int v) { return new Vector4Int(v.z, v.z, v.w, v.w); }
		public static Vector4Int zwxx(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.x, v.x); }
		public static Vector4Int zwxy(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.x, v.y); }
		public static Vector4Int zwxz(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.x, v.z); }
		public static Vector4Int zwxw(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.x, v.w); }
		public static Vector4Int zwyx(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.y, v.x); }
		public static Vector4Int zwyy(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.y, v.y); }
		public static Vector4Int zwyz(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.y, v.z); }
		public static Vector4Int zwyw(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.y, v.w); }
		public static Vector4Int zwzx(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.z, v.x); }
		public static Vector4Int zwzy(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.z, v.y); }
		public static Vector4Int zwzz(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.z, v.z); }
		public static Vector4Int zwzw(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.z, v.w); }
		public static Vector4Int zwwx(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.w, v.x); }
		public static Vector4Int zwwy(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.w, v.y); }
		public static Vector4Int zwwz(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.w, v.z); }
		public static Vector4Int zwww(this Vector4Int v) { return new Vector4Int(v.z, v.w, v.w, v.w); }
		public static Vector4Int wxxx(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.x, v.x); }
		public static Vector4Int wxxy(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.x, v.y); }
		public static Vector4Int wxxz(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.x, v.z); }
		public static Vector4Int wxxw(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.x, v.w); }
		public static Vector4Int wxyx(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.y, v.x); }
		public static Vector4Int wxyy(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.y, v.y); }
		public static Vector4Int wxyz(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.y, v.z); }
		public static Vector4Int wxyw(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.y, v.w); }
		public static Vector4Int wxzx(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.z, v.x); }
		public static Vector4Int wxzy(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.z, v.y); }
		public static Vector4Int wxzz(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.z, v.z); }
		public static Vector4Int wxzw(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.z, v.w); }
		public static Vector4Int wxwx(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.w, v.x); }
		public static Vector4Int wxwy(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.w, v.y); }
		public static Vector4Int wxwz(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.w, v.z); }
		public static Vector4Int wxww(this Vector4Int v) { return new Vector4Int(v.w, v.x, v.w, v.w); }
		public static Vector4Int wyxx(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.x, v.x); }
		public static Vector4Int wyxy(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.x, v.y); }
		public static Vector4Int wyxz(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.x, v.z); }
		public static Vector4Int wyxw(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.x, v.w); }
		public static Vector4Int wyyx(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.y, v.x); }
		public static Vector4Int wyyy(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.y, v.y); }
		public static Vector4Int wyyz(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.y, v.z); }
		public static Vector4Int wyyw(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.y, v.w); }
		public static Vector4Int wyzx(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.z, v.x); }
		public static Vector4Int wyzy(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.z, v.y); }
		public static Vector4Int wyzz(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.z, v.z); }
		public static Vector4Int wyzw(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.z, v.w); }
		public static Vector4Int wywx(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.w, v.x); }
		public static Vector4Int wywy(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.w, v.y); }
		public static Vector4Int wywz(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.w, v.z); }
		public static Vector4Int wyww(this Vector4Int v) { return new Vector4Int(v.w, v.y, v.w, v.w); }
		public static Vector4Int wzxx(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.x, v.x); }
		public static Vector4Int wzxy(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.x, v.y); }
		public static Vector4Int wzxz(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.x, v.z); }
		public static Vector4Int wzxw(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.x, v.w); }
		public static Vector4Int wzyx(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.y, v.x); }
		public static Vector4Int wzyy(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.y, v.y); }
		public static Vector4Int wzyz(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.y, v.z); }
		public static Vector4Int wzyw(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.y, v.w); }
		public static Vector4Int wzzx(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.z, v.x); }
		public static Vector4Int wzzy(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.z, v.y); }
		public static Vector4Int wzzz(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.z, v.z); }
		public static Vector4Int wzzw(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.z, v.w); }
		public static Vector4Int wzwx(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.w, v.x); }
		public static Vector4Int wzwy(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.w, v.y); }
		public static Vector4Int wzwz(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.w, v.z); }
		public static Vector4Int wzww(this Vector4Int v) { return new Vector4Int(v.w, v.z, v.w, v.w); }
		public static Vector4Int wwxx(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.x, v.x); }
		public static Vector4Int wwxy(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.x, v.y); }
		public static Vector4Int wwxz(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.x, v.z); }
		public static Vector4Int wwxw(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.x, v.w); }
		public static Vector4Int wwyx(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.y, v.x); }
		public static Vector4Int wwyy(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.y, v.y); }
		public static Vector4Int wwyz(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.y, v.z); }
		public static Vector4Int wwyw(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.y, v.w); }
		public static Vector4Int wwzx(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.z, v.x); }
		public static Vector4Int wwzy(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.z, v.y); }
		public static Vector4Int wwzz(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.z, v.z); }
		public static Vector4Int wwzw(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.z, v.w); }
		public static Vector4Int wwwx(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.w, v.x); }
		public static Vector4Int wwwy(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.w, v.y); }
		public static Vector4Int wwwz(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.w, v.z); }
		public static Vector4Int wwww(this Vector4Int v) { return new Vector4Int(v.w, v.w, v.w, v.w); }
	}
}
