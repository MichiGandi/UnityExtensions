//Extension for Unity Vector
// - Vector2
// - Vector3
// - Vector4
//Source: https://github.com/bigmarch/BigMarch/blob/master/Assets/BigMarch/Swizzle/Swizzle.cs
using UnityEngine;


namespace Extension.Vector
{
	public static class SwizzleVector2To2
	{
		public static Vector2 xx(this Vector2 v) { return new Vector2(v.x, v.x); }
		public static Vector2 xy(this Vector2 v) { return new Vector2(v.x, v.y); }
		public static Vector2 yx(this Vector2 v) { return new Vector2(v.y, v.x); }
		public static Vector2 yy(this Vector2 v) { return new Vector2(v.y, v.y); }
	}


	public static class SwizzleVector3To2
	{
		public static Vector2 xx(this Vector3 v) { return new Vector2(v.x, v.x); }
		public static Vector2 xy(this Vector3 v) { return new Vector2(v.x, v.y); }
		public static Vector2 xz(this Vector3 v) { return new Vector2(v.x, v.z); }
		public static Vector2 yx(this Vector3 v) { return new Vector2(v.y, v.x); }
		public static Vector2 yy(this Vector3 v) { return new Vector2(v.y, v.y); }
		public static Vector2 yz(this Vector3 v) { return new Vector2(v.y, v.z); }
		public static Vector2 zx(this Vector3 v) { return new Vector2(v.z, v.x); }
		public static Vector2 zy(this Vector3 v) { return new Vector2(v.z, v.y); }
		public static Vector2 zz(this Vector3 v) { return new Vector2(v.z, v.z); }
	}


	public static class SwizzleVector4To2
	{
		public static Vector2 xx(this Vector4 v) { return new Vector2(v.x, v.x); }
		public static Vector2 xy(this Vector4 v) { return new Vector2(v.x, v.y); }
		public static Vector2 xz(this Vector4 v) { return new Vector2(v.x, v.z); }
		public static Vector2 xw(this Vector4 v) { return new Vector2(v.x, v.w); }
		public static Vector2 yx(this Vector4 v) { return new Vector2(v.y, v.x); }
		public static Vector2 yy(this Vector4 v) { return new Vector2(v.y, v.y); }
		public static Vector2 yz(this Vector4 v) { return new Vector2(v.y, v.z); }
		public static Vector2 yw(this Vector4 v) { return new Vector2(v.y, v.w); }
		public static Vector2 zx(this Vector4 v) { return new Vector2(v.z, v.x); }
		public static Vector2 zy(this Vector4 v) { return new Vector2(v.z, v.y); }
		public static Vector2 zz(this Vector4 v) { return new Vector2(v.z, v.z); }
		public static Vector2 zw(this Vector4 v) { return new Vector2(v.z, v.w); }
		public static Vector2 wx(this Vector4 v) { return new Vector2(v.w, v.x); }
		public static Vector2 wy(this Vector4 v) { return new Vector2(v.w, v.y); }
		public static Vector2 wz(this Vector4 v) { return new Vector2(v.w, v.z); }
		public static Vector2 ww(this Vector4 v) { return new Vector2(v.w, v.w); }
	}


	public static class SwizzleVector2To3
	{
		public static Vector3 xxx(this Vector2 v         ) { return new Vector3(v.x, v.x, v.x); }
		public static Vector3 xxy(this Vector2 v         ) { return new Vector3(v.x, v.x, v.y); }
		public static Vector3 xxz(this Vector2 v, float z) { return new Vector3(v.x, v.x,   z); }
		public static Vector3 xyx(this Vector2 v         ) { return new Vector3(v.x, v.y, v.x); }
		public static Vector3 xyy(this Vector2 v         ) { return new Vector3(v.x, v.y, v.y); }
		public static Vector3 xyz(this Vector2 v, float z) { return new Vector3(v.x, v.y,   z); }
		public static Vector3 xzx(this Vector2 v, float z) { return new Vector3(v.x,   z, v.x); }
		public static Vector3 xzy(this Vector2 v, float z) { return new Vector3(v.x,   z, v.y); }
		public static Vector3 xzz(this Vector2 v, float z) { return new Vector3(v.x,   z,   z); }
		public static Vector3 yxx(this Vector2 v         ) { return new Vector3(v.y, v.x, v.x); }
		public static Vector3 yxy(this Vector2 v         ) { return new Vector3(v.y, v.x, v.y); }
		public static Vector3 yxz(this Vector2 v, float z) { return new Vector3(v.y, v.x,   z); }
		public static Vector3 yyx(this Vector2 v         ) { return new Vector3(v.y, v.y, v.x); }
		public static Vector3 yyy(this Vector2 v         ) { return new Vector3(v.y, v.y, v.y); }
		public static Vector3 yyz(this Vector2 v, float z) { return new Vector3(v.y, v.y,   z); }
		public static Vector3 yzx(this Vector2 v, float z) { return new Vector3(v.y,   z, v.x); }
		public static Vector3 yzy(this Vector2 v, float z) { return new Vector3(v.y,   z, v.y); }
		public static Vector3 yzz(this Vector2 v, float z) { return new Vector3(v.y,   z,   z); }
		public static Vector3 zxx(this Vector2 v, float z) { return new Vector3(  z, v.x, v.x); }
		public static Vector3 zxy(this Vector2 v, float z) { return new Vector3(  z, v.x, v.y); }
		public static Vector3 zxz(this Vector2 v, float z) { return new Vector3(  z, v.x,   z); }
		public static Vector3 zyx(this Vector2 v, float z) { return new Vector3(  z, v.y, v.x); }
		public static Vector3 zyy(this Vector2 v, float z) { return new Vector3(  z, v.y, v.y); }
		public static Vector3 zyz(this Vector2 v, float z) { return new Vector3(  z, v.y,   z); }
		public static Vector3 zzx(this Vector2 v, float z) { return new Vector3(  z,   z, v.x); }
		public static Vector3 zzy(this Vector2 v, float z) { return new Vector3(  z,   z, v.y); }
		public static Vector3 zzz(this Vector2 v, float z) { return new Vector3(  z,   z,   z); }
	}


	public static class SwizzleVector3To3
	{
		public static Vector3 xxx(this Vector3 v) { return new Vector3(v.x, v.x, v.x); }
		public static Vector3 xxy(this Vector3 v) { return new Vector3(v.x, v.x, v.y); }
		public static Vector3 xxz(this Vector3 v) { return new Vector3(v.x, v.x, v.z); }
		public static Vector3 xyx(this Vector3 v) { return new Vector3(v.x, v.y, v.x); }
		public static Vector3 xyy(this Vector3 v) { return new Vector3(v.x, v.y, v.y); }
		public static Vector3 xyz(this Vector3 v) { return new Vector3(v.x, v.y, v.z); }
		public static Vector3 xzx(this Vector3 v) { return new Vector3(v.x, v.z, v.x); }
		public static Vector3 xzy(this Vector3 v) { return new Vector3(v.x, v.z, v.y); }
		public static Vector3 xzz(this Vector3 v) { return new Vector3(v.x, v.z, v.z); }
		public static Vector3 yxx(this Vector3 v) { return new Vector3(v.y, v.x, v.x); }
		public static Vector3 yxy(this Vector3 v) { return new Vector3(v.y, v.x, v.y); }
		public static Vector3 yxz(this Vector3 v) { return new Vector3(v.y, v.x, v.z); }
		public static Vector3 yyx(this Vector3 v) { return new Vector3(v.y, v.y, v.x); }
		public static Vector3 yyy(this Vector3 v) { return new Vector3(v.y, v.y, v.y); }
		public static Vector3 yyz(this Vector3 v) { return new Vector3(v.y, v.y, v.z); }
		public static Vector3 yzx(this Vector3 v) { return new Vector3(v.y, v.z, v.x); }
		public static Vector3 yzy(this Vector3 v) { return new Vector3(v.y, v.z, v.y); }
		public static Vector3 yzz(this Vector3 v) { return new Vector3(v.y, v.z, v.z); }
		public static Vector3 zxx(this Vector3 v) { return new Vector3(v.z, v.x, v.x); }
		public static Vector3 zxy(this Vector3 v) { return new Vector3(v.z, v.x, v.y); }
		public static Vector3 zxz(this Vector3 v) { return new Vector3(v.z, v.x, v.z); }
		public static Vector3 zyx(this Vector3 v) { return new Vector3(v.z, v.y, v.x); }
		public static Vector3 zyy(this Vector3 v) { return new Vector3(v.z, v.y, v.y); }
		public static Vector3 zyz(this Vector3 v) { return new Vector3(v.z, v.y, v.z); }
		public static Vector3 zzx(this Vector3 v) { return new Vector3(v.z, v.z, v.x); }
		public static Vector3 zzy(this Vector3 v) { return new Vector3(v.z, v.z, v.y); }
		public static Vector3 zzz(this Vector3 v) { return new Vector3(v.z, v.z, v.z); }
	}


	public static class SwizzleVector4To3
	{
		public static Vector3 xxx(this Vector4 v) { return new Vector3(v.x, v.x, v.x); }
		public static Vector3 xxy(this Vector4 v) { return new Vector3(v.x, v.x, v.y); }
		public static Vector3 xxz(this Vector4 v) { return new Vector3(v.x, v.x, v.z); }
		public static Vector3 xxw(this Vector4 v) { return new Vector3(v.x, v.x, v.w); }
		public static Vector3 xyx(this Vector4 v) { return new Vector3(v.x, v.y, v.x); }
		public static Vector3 xyy(this Vector4 v) { return new Vector3(v.x, v.y, v.y); }
		public static Vector3 xyz(this Vector4 v) { return new Vector3(v.x, v.y, v.z); }
		public static Vector3 xyw(this Vector4 v) { return new Vector3(v.x, v.y, v.w); }
		public static Vector3 xzx(this Vector4 v) { return new Vector3(v.x, v.z, v.x); }
		public static Vector3 xzy(this Vector4 v) { return new Vector3(v.x, v.z, v.y); }
		public static Vector3 xzz(this Vector4 v) { return new Vector3(v.x, v.z, v.z); }
		public static Vector3 xzw(this Vector4 v) { return new Vector3(v.x, v.z, v.w); }
		public static Vector3 xwx(this Vector4 v) { return new Vector3(v.x, v.w, v.x); }
		public static Vector3 xwy(this Vector4 v) { return new Vector3(v.x, v.w, v.y); }
		public static Vector3 xwz(this Vector4 v) { return new Vector3(v.x, v.w, v.z); }
		public static Vector3 xww(this Vector4 v) { return new Vector3(v.x, v.w, v.w); }
		public static Vector3 yxx(this Vector4 v) { return new Vector3(v.y, v.x, v.x); }
		public static Vector3 yxy(this Vector4 v) { return new Vector3(v.y, v.x, v.y); }
		public static Vector3 yxz(this Vector4 v) { return new Vector3(v.y, v.x, v.z); }
		public static Vector3 yxw(this Vector4 v) { return new Vector3(v.y, v.x, v.w); }
		public static Vector3 yyx(this Vector4 v) { return new Vector3(v.y, v.y, v.x); }
		public static Vector3 yyy(this Vector4 v) { return new Vector3(v.y, v.y, v.y); }
		public static Vector3 yyz(this Vector4 v) { return new Vector3(v.y, v.y, v.z); }
		public static Vector3 yyw(this Vector4 v) { return new Vector3(v.y, v.y, v.w); }
		public static Vector3 yzx(this Vector4 v) { return new Vector3(v.y, v.z, v.x); }
		public static Vector3 yzy(this Vector4 v) { return new Vector3(v.y, v.z, v.y); }
		public static Vector3 yzz(this Vector4 v) { return new Vector3(v.y, v.z, v.z); }
		public static Vector3 yzw(this Vector4 v) { return new Vector3(v.y, v.z, v.w); }
		public static Vector3 ywx(this Vector4 v) { return new Vector3(v.y, v.w, v.x); }
		public static Vector3 ywy(this Vector4 v) { return new Vector3(v.y, v.w, v.y); }
		public static Vector3 ywz(this Vector4 v) { return new Vector3(v.y, v.w, v.z); }
		public static Vector3 yww(this Vector4 v) { return new Vector3(v.y, v.w, v.w); }
		public static Vector3 zxx(this Vector4 v) { return new Vector3(v.z, v.x, v.x); }
		public static Vector3 zxy(this Vector4 v) { return new Vector3(v.z, v.x, v.y); }
		public static Vector3 zxz(this Vector4 v) { return new Vector3(v.z, v.x, v.z); }
		public static Vector3 zxw(this Vector4 v) { return new Vector3(v.z, v.x, v.w); }
		public static Vector3 zyx(this Vector4 v) { return new Vector3(v.z, v.y, v.x); }
		public static Vector3 zyy(this Vector4 v) { return new Vector3(v.z, v.y, v.y); }
		public static Vector3 zyz(this Vector4 v) { return new Vector3(v.z, v.y, v.z); }
		public static Vector3 zyw(this Vector4 v) { return new Vector3(v.z, v.y, v.w); }
		public static Vector3 zzx(this Vector4 v) { return new Vector3(v.z, v.z, v.x); }
		public static Vector3 zzy(this Vector4 v) { return new Vector3(v.z, v.z, v.y); }
		public static Vector3 zzz(this Vector4 v) { return new Vector3(v.z, v.z, v.z); }
		public static Vector3 zzw(this Vector4 v) { return new Vector3(v.z, v.z, v.w); }
		public static Vector3 zwx(this Vector4 v) { return new Vector3(v.z, v.w, v.x); }
		public static Vector3 zwy(this Vector4 v) { return new Vector3(v.z, v.w, v.y); }
		public static Vector3 zwz(this Vector4 v) { return new Vector3(v.z, v.w, v.z); }
		public static Vector3 zww(this Vector4 v) { return new Vector3(v.z, v.w, v.w); }
		public static Vector3 wxx(this Vector4 v) { return new Vector3(v.w, v.x, v.x); }
		public static Vector3 wxy(this Vector4 v) { return new Vector3(v.w, v.x, v.y); }
		public static Vector3 wxz(this Vector4 v) { return new Vector3(v.w, v.x, v.z); }
		public static Vector3 wxw(this Vector4 v) { return new Vector3(v.w, v.x, v.w); }
		public static Vector3 wyx(this Vector4 v) { return new Vector3(v.w, v.y, v.x); }
		public static Vector3 wyy(this Vector4 v) { return new Vector3(v.w, v.y, v.y); }
		public static Vector3 wyz(this Vector4 v) { return new Vector3(v.w, v.y, v.z); }
		public static Vector3 wyw(this Vector4 v) { return new Vector3(v.w, v.y, v.w); }
		public static Vector3 wzx(this Vector4 v) { return new Vector3(v.w, v.z, v.x); }
		public static Vector3 wzy(this Vector4 v) { return new Vector3(v.w, v.z, v.y); }
		public static Vector3 wzz(this Vector4 v) { return new Vector3(v.w, v.z, v.z); }
		public static Vector3 wzw(this Vector4 v) { return new Vector3(v.w, v.z, v.w); }
		public static Vector3 wwx(this Vector4 v) { return new Vector3(v.w, v.w, v.x); }
		public static Vector3 wwy(this Vector4 v) { return new Vector3(v.w, v.w, v.y); }
		public static Vector3 wwz(this Vector4 v) { return new Vector3(v.w, v.w, v.z); }
		public static Vector3 www(this Vector4 v) { return new Vector3(v.w, v.w, v.w); }
	}


	public static class SwizzleVector2To4
	{
		public static Vector4 xxxx(this Vector2 v                  ) { return new Vector4(v.x, v.x, v.x, v.x); }
		public static Vector4 xxxy(this Vector2 v                  ) { return new Vector4(v.x, v.x, v.x, v.y); }
		public static Vector4 xxxz(this Vector2 v, float z         ) { return new Vector4(v.x, v.x, v.x,   z); }
		public static Vector4 xxxw(this Vector2 v, float w         ) { return new Vector4(v.x, v.x, v.x,   w); }
		public static Vector4 xxyx(this Vector2 v                  ) { return new Vector4(v.x, v.x, v.y, v.x); }
		public static Vector4 xxyy(this Vector2 v                  ) { return new Vector4(v.x, v.x, v.y, v.y); }
		public static Vector4 xxyz(this Vector2 v, float z         ) { return new Vector4(v.x, v.x, v.y,   z); }
		public static Vector4 xxyw(this Vector2 v, float w         ) { return new Vector4(v.x, v.x, v.y,   w); }
		public static Vector4 xxzx(this Vector2 v, float z         ) { return new Vector4(v.x, v.x,   z, v.x); }
		public static Vector4 xxzy(this Vector2 v, float z         ) { return new Vector4(v.x, v.x,   z, v.y); }
		public static Vector4 xxzz(this Vector2 v, float z         ) { return new Vector4(v.x, v.x,   z,   z); }
		public static Vector4 xxzw(this Vector2 v, float z, float w) { return new Vector4(v.x, v.x,   z,   w); }
		public static Vector4 xxwx(this Vector2 v, float w         ) { return new Vector4(v.x, v.x,   w, v.x); }
		public static Vector4 xxwy(this Vector2 v, float w         ) { return new Vector4(v.x, v.x,   w, v.y); }
		public static Vector4 xxwz(this Vector2 v, float z, float w) { return new Vector4(v.x, v.x,   w,   z); }
		public static Vector4 xxww(this Vector2 v, float w         ) { return new Vector4(v.x, v.x,   w,   w); }
		public static Vector4 xyxx(this Vector2 v                  ) { return new Vector4(v.x, v.y, v.x, v.x); }
		public static Vector4 xyxy(this Vector2 v                  ) { return new Vector4(v.x, v.y, v.x, v.y); }
		public static Vector4 xyxz(this Vector2 v, float z         ) { return new Vector4(v.x, v.y, v.x,   z); }
		public static Vector4 xyxw(this Vector2 v, float w         ) { return new Vector4(v.x, v.y, v.x,   w); }
		public static Vector4 xyyx(this Vector2 v                  ) { return new Vector4(v.x, v.y, v.y, v.x); }
		public static Vector4 xyyy(this Vector2 v                  ) { return new Vector4(v.x, v.y, v.y, v.y); }
		public static Vector4 xyyz(this Vector2 v, float z         ) { return new Vector4(v.x, v.y, v.y,   z); }
		public static Vector4 xyyw(this Vector2 v, float w         ) { return new Vector4(v.x, v.y, v.y,   w); }
		public static Vector4 xyzx(this Vector2 v, float z         ) { return new Vector4(v.x, v.y,   z, v.x); }
		public static Vector4 xyzy(this Vector2 v, float z         ) { return new Vector4(v.x, v.y,   z, v.y); }
		public static Vector4 xyzz(this Vector2 v, float z         ) { return new Vector4(v.x, v.y,   z,   z); }
		public static Vector4 xyzw(this Vector2 v, float z, float w) { return new Vector4(v.x, v.y,   z,   w); }
		public static Vector4 xywx(this Vector2 v, float w         ) { return new Vector4(v.x, v.y,   w, v.x); }
		public static Vector4 xywy(this Vector2 v, float w         ) { return new Vector4(v.x, v.y,   w, v.y); }
		public static Vector4 xywz(this Vector2 v, float z, float w) { return new Vector4(v.x, v.y,   w,   z); }
		public static Vector4 xyww(this Vector2 v, float w         ) { return new Vector4(v.x, v.y,   w,   w); }
		public static Vector4 xzxx(this Vector2 v, float z         ) { return new Vector4(v.x,   z, v.x, v.x); }
		public static Vector4 xzxy(this Vector2 v, float z         ) { return new Vector4(v.x,   z, v.x, v.y); }
		public static Vector4 xzxz(this Vector2 v, float z         ) { return new Vector4(v.x,   z, v.x,   z); }
		public static Vector4 xzxw(this Vector2 v, float z, float w) { return new Vector4(v.x,   z, v.x,   w); }
		public static Vector4 xzyx(this Vector2 v, float z         ) { return new Vector4(v.x,   z, v.y, v.x); }
		public static Vector4 xzyy(this Vector2 v, float z         ) { return new Vector4(v.x,   z, v.y, v.y); }
		public static Vector4 xzyz(this Vector2 v, float z         ) { return new Vector4(v.x,   z, v.y,   z); }
		public static Vector4 xzyw(this Vector2 v, float z, float w) { return new Vector4(v.x,   z, v.y,   w); }
		public static Vector4 xzzx(this Vector2 v, float z         ) { return new Vector4(v.x,   z,   z, v.x); }
		public static Vector4 xzzy(this Vector2 v, float z         ) { return new Vector4(v.x,   z,   z, v.y); }
		public static Vector4 xzzz(this Vector2 v, float z         ) { return new Vector4(v.x,   z,   z,   z); }
		public static Vector4 xzzw(this Vector2 v, float z, float w) { return new Vector4(v.x,   z,   z,   w); }
		public static Vector4 xzwx(this Vector2 v, float z, float w) { return new Vector4(v.x,   z,   w, v.x); }
		public static Vector4 xzwy(this Vector2 v, float z, float w) { return new Vector4(v.x,   z,   w, v.y); }
		public static Vector4 xzwz(this Vector2 v, float z, float w) { return new Vector4(v.x,   z,   w,   z); }
		public static Vector4 xzww(this Vector2 v, float z, float w) { return new Vector4(v.x,   z,   w,   w); }
		public static Vector4 xwxx(this Vector2 v, float w         ) { return new Vector4(v.x,   w, v.x, v.x); }
		public static Vector4 xwxy(this Vector2 v, float w         ) { return new Vector4(v.x,   w, v.x, v.y); }
		public static Vector4 xwxz(this Vector2 v, float z, float w) { return new Vector4(v.x,   w, v.x,   z); }
		public static Vector4 xwxw(this Vector2 v, float w         ) { return new Vector4(v.x,   w, v.x,   w); }
		public static Vector4 xwyx(this Vector2 v, float w         ) { return new Vector4(v.x,   w, v.y, v.x); }
		public static Vector4 xwyy(this Vector2 v, float w         ) { return new Vector4(v.x,   w, v.y, v.y); }
		public static Vector4 xwyz(this Vector2 v, float z, float w) { return new Vector4(v.x,   w, v.y,   z); }
		public static Vector4 xwyw(this Vector2 v, float w         ) { return new Vector4(v.x,   w, v.y,   w); }
		public static Vector4 xwzx(this Vector2 v, float z, float w) { return new Vector4(v.x,   w,   z, v.x); }
		public static Vector4 xwzy(this Vector2 v, float z, float w) { return new Vector4(v.x,   w,   z, v.y); }
		public static Vector4 xwzz(this Vector2 v, float z, float w) { return new Vector4(v.x,   w,   z,   z); }
		public static Vector4 xwzw(this Vector2 v, float z, float w) { return new Vector4(v.x,   w,   z,   w); }
		public static Vector4 xwwx(this Vector2 v, float w         ) { return new Vector4(v.x,   w,   w, v.x); }
		public static Vector4 xwwy(this Vector2 v, float w         ) { return new Vector4(v.x,   w,   w, v.y); }
		public static Vector4 xwwz(this Vector2 v, float z, float w) { return new Vector4(v.x,   w,   w,   z); }
		public static Vector4 xwww(this Vector2 v, float w         ) { return new Vector4(v.x,   w,   w,   w); }
		public static Vector4 yxxx(this Vector2 v                  ) { return new Vector4(v.y, v.x, v.x, v.x); }
		public static Vector4 yxxy(this Vector2 v                  ) { return new Vector4(v.y, v.x, v.x, v.y); }
		public static Vector4 yxxz(this Vector2 v, float z         ) { return new Vector4(v.y, v.x, v.x,   z); }
		public static Vector4 yxxw(this Vector2 v, float w         ) { return new Vector4(v.y, v.x, v.x,   w); }
		public static Vector4 yxyx(this Vector2 v                  ) { return new Vector4(v.y, v.x, v.y, v.x); }
		public static Vector4 yxyy(this Vector2 v                  ) { return new Vector4(v.y, v.x, v.y, v.y); }
		public static Vector4 yxyz(this Vector2 v, float z         ) { return new Vector4(v.y, v.x, v.y,   z); }
		public static Vector4 yxyw(this Vector2 v, float w         ) { return new Vector4(v.y, v.x, v.y,   w); }
		public static Vector4 yxzx(this Vector2 v, float z         ) { return new Vector4(v.y, v.x,   z, v.x); }
		public static Vector4 yxzy(this Vector2 v, float z         ) { return new Vector4(v.y, v.x,   z, v.y); }
		public static Vector4 yxzz(this Vector2 v, float z         ) { return new Vector4(v.y, v.x,   z,   z); }
		public static Vector4 yxzw(this Vector2 v, float z, float w) { return new Vector4(v.y, v.x,   z,   w); }
		public static Vector4 yxwx(this Vector2 v, float w         ) { return new Vector4(v.y, v.x,   w, v.x); }
		public static Vector4 yxwy(this Vector2 v, float w         ) { return new Vector4(v.y, v.x,   w, v.y); }
		public static Vector4 yxwz(this Vector2 v, float z, float w) { return new Vector4(v.y, v.x,   w,   z); }
		public static Vector4 yxww(this Vector2 v, float w         ) { return new Vector4(v.y, v.x,   w,   w); }
		public static Vector4 yyxx(this Vector2 v                  ) { return new Vector4(v.y, v.y, v.x, v.x); }
		public static Vector4 yyxy(this Vector2 v                  ) { return new Vector4(v.y, v.y, v.x, v.y); }
		public static Vector4 yyxz(this Vector2 v, float z         ) { return new Vector4(v.y, v.y, v.x,   z); }
		public static Vector4 yyxw(this Vector2 v, float w         ) { return new Vector4(v.y, v.y, v.x,   w); }
		public static Vector4 yyyx(this Vector2 v                  ) { return new Vector4(v.y, v.y, v.y, v.x); }
		public static Vector4 yyyy(this Vector2 v                  ) { return new Vector4(v.y, v.y, v.y, v.y); }
		public static Vector4 yyyz(this Vector2 v, float z         ) { return new Vector4(v.y, v.y, v.y,   z); }
		public static Vector4 yyyw(this Vector2 v, float w         ) { return new Vector4(v.y, v.y, v.y,   w); }
		public static Vector4 yyzx(this Vector2 v, float z         ) { return new Vector4(v.y, v.y,   z, v.x); }
		public static Vector4 yyzy(this Vector2 v, float z         ) { return new Vector4(v.y, v.y,   z, v.y); }
		public static Vector4 yyzz(this Vector2 v, float z         ) { return new Vector4(v.y, v.y,   z,   z); }
		public static Vector4 yyzw(this Vector2 v, float z, float w) { return new Vector4(v.y, v.y,   z,   w); }
		public static Vector4 yywx(this Vector2 v, float w         ) { return new Vector4(v.y, v.y,   w, v.x); }
		public static Vector4 yywy(this Vector2 v, float w         ) { return new Vector4(v.y, v.y,   w, v.y); }
		public static Vector4 yywz(this Vector2 v, float z, float w) { return new Vector4(v.y, v.y,   w,   z); }
		public static Vector4 yyww(this Vector2 v, float w         ) { return new Vector4(v.y, v.y,   w,   w); }
		public static Vector4 yzxx(this Vector2 v, float z         ) { return new Vector4(v.y,   z, v.x, v.x); }
		public static Vector4 yzxy(this Vector2 v, float z         ) { return new Vector4(v.y,   z, v.x, v.y); }
		public static Vector4 yzxz(this Vector2 v, float z         ) { return new Vector4(v.y,   z, v.x,   z); }
		public static Vector4 yzxw(this Vector2 v, float z, float w) { return new Vector4(v.y,   z, v.x,   w); }
		public static Vector4 yzyx(this Vector2 v, float z         ) { return new Vector4(v.y,   z, v.y, v.x); }
		public static Vector4 yzyy(this Vector2 v, float z         ) { return new Vector4(v.y,   z, v.y, v.y); }
		public static Vector4 yzyz(this Vector2 v, float z         ) { return new Vector4(v.y,   z, v.y,   z); }
		public static Vector4 yzyw(this Vector2 v, float z, float w) { return new Vector4(v.y,   z, v.y,   w); }
		public static Vector4 yzzx(this Vector2 v, float z         ) { return new Vector4(v.y,   z,   z, v.x); }
		public static Vector4 yzzy(this Vector2 v, float z         ) { return new Vector4(v.y,   z,   z, v.y); }
		public static Vector4 yzzz(this Vector2 v, float z         ) { return new Vector4(v.y,   z,   z,   z); }
		public static Vector4 yzzw(this Vector2 v, float z, float w) { return new Vector4(v.y,   z,   z,   w); }
		public static Vector4 yzwx(this Vector2 v, float z, float w) { return new Vector4(v.y,   z,   w, v.x); }
		public static Vector4 yzwy(this Vector2 v, float z, float w) { return new Vector4(v.y,   z,   w, v.y); }
		public static Vector4 yzwz(this Vector2 v, float z, float w) { return new Vector4(v.y,   z,   w,   z); }
		public static Vector4 yzww(this Vector2 v, float z, float w) { return new Vector4(v.y,   z,   w,   w); }
		public static Vector4 ywxx(this Vector2 v, float w         ) { return new Vector4(v.y,   w, v.x, v.x); }
		public static Vector4 ywxy(this Vector2 v, float w         ) { return new Vector4(v.y,   w, v.x, v.y); }
		public static Vector4 ywxz(this Vector2 v, float z, float w) { return new Vector4(v.y,   w, v.x,   z); }
		public static Vector4 ywxw(this Vector2 v, float w         ) { return new Vector4(v.y,   w, v.x,   w); }
		public static Vector4 ywyx(this Vector2 v, float w         ) { return new Vector4(v.y,   w, v.y, v.x); }
		public static Vector4 ywyy(this Vector2 v, float w         ) { return new Vector4(v.y,   w, v.y, v.y); }
		public static Vector4 ywyz(this Vector2 v, float z, float w) { return new Vector4(v.y,   w, v.y,   z); }
		public static Vector4 ywyw(this Vector2 v, float w         ) { return new Vector4(v.y,   w, v.y,   w); }
		public static Vector4 ywzx(this Vector2 v, float z, float w) { return new Vector4(v.y,   w,   z, v.x); }
		public static Vector4 ywzy(this Vector2 v, float z, float w) { return new Vector4(v.y,   w,   z, v.y); }
		public static Vector4 ywzz(this Vector2 v, float z, float w) { return new Vector4(v.y,   w,   z,   z); }
		public static Vector4 ywzw(this Vector2 v, float z, float w) { return new Vector4(v.y,   w,   z,   w); }
		public static Vector4 ywwx(this Vector2 v, float w         ) { return new Vector4(v.y,   w,   w, v.x); }
		public static Vector4 ywwy(this Vector2 v, float w         ) { return new Vector4(v.y,   w,   w, v.y); }
		public static Vector4 ywwz(this Vector2 v, float z, float w) { return new Vector4(v.y,   w,   w,   z); }
		public static Vector4 ywww(this Vector2 v, float w         ) { return new Vector4(v.y,   w,   w,   w); }
		public static Vector4 zxxx(this Vector2 v, float z         ) { return new Vector4(  z, v.x, v.x, v.x); }
		public static Vector4 zxxy(this Vector2 v, float z         ) { return new Vector4(  z, v.x, v.x, v.y); }
		public static Vector4 zxxz(this Vector2 v, float z         ) { return new Vector4(  z, v.x, v.x,   z); }
		public static Vector4 zxxw(this Vector2 v, float z, float w) { return new Vector4(  z, v.x, v.x,   w); }
		public static Vector4 zxyx(this Vector2 v, float z         ) { return new Vector4(  z, v.x, v.y, v.x); }
		public static Vector4 zxyy(this Vector2 v, float z         ) { return new Vector4(  z, v.x, v.y, v.y); }
		public static Vector4 zxyz(this Vector2 v, float z         ) { return new Vector4(  z, v.x, v.y,   z); }
		public static Vector4 zxyw(this Vector2 v, float z, float w) { return new Vector4(  z, v.x, v.y,   w); }
		public static Vector4 zxzx(this Vector2 v, float z         ) { return new Vector4(  z, v.x,   z, v.x); }
		public static Vector4 zxzy(this Vector2 v, float z         ) { return new Vector4(  z, v.x,   z, v.y); }
		public static Vector4 zxzz(this Vector2 v, float z         ) { return new Vector4(  z, v.x,   z,   z); }
		public static Vector4 zxzw(this Vector2 v, float z, float w) { return new Vector4(  z, v.x,   z,   w); }
		public static Vector4 zxwx(this Vector2 v, float z, float w) { return new Vector4(  z, v.x,   w, v.x); }
		public static Vector4 zxwy(this Vector2 v, float z, float w) { return new Vector4(  z, v.x,   w, v.y); }
		public static Vector4 zxwz(this Vector2 v, float z, float w) { return new Vector4(  z, v.x,   w,   z); }
		public static Vector4 zxww(this Vector2 v, float z, float w) { return new Vector4(  z, v.x,   w,   w); }
		public static Vector4 zyxx(this Vector2 v, float z         ) { return new Vector4(  z, v.y, v.x, v.x); }
		public static Vector4 zyxy(this Vector2 v, float z         ) { return new Vector4(  z, v.y, v.x, v.y); }
		public static Vector4 zyxz(this Vector2 v, float z         ) { return new Vector4(  z, v.y, v.x,   z); }
		public static Vector4 zyxw(this Vector2 v, float z, float w) { return new Vector4(  z, v.y, v.x,   w); }
		public static Vector4 zyyx(this Vector2 v, float z         ) { return new Vector4(  z, v.y, v.y, v.x); }
		public static Vector4 zyyy(this Vector2 v, float z         ) { return new Vector4(  z, v.y, v.y, v.y); }
		public static Vector4 zyyz(this Vector2 v, float z         ) { return new Vector4(  z, v.y, v.y,   z); }
		public static Vector4 zyyw(this Vector2 v, float z, float w) { return new Vector4(  z, v.y, v.y,   w); }
		public static Vector4 zyzx(this Vector2 v, float z         ) { return new Vector4(  z, v.y,   z, v.x); }
		public static Vector4 zyzy(this Vector2 v, float z         ) { return new Vector4(  z, v.y,   z, v.y); }
		public static Vector4 zyzz(this Vector2 v, float z         ) { return new Vector4(  z, v.y,   z,   z); }
		public static Vector4 zyzw(this Vector2 v, float z, float w) { return new Vector4(  z, v.y,   z,   w); }
		public static Vector4 zywx(this Vector2 v, float z, float w) { return new Vector4(  z, v.y,   w, v.x); }
		public static Vector4 zywy(this Vector2 v, float z, float w) { return new Vector4(  z, v.y,   w, v.y); }
		public static Vector4 zywz(this Vector2 v, float z, float w) { return new Vector4(  z, v.y,   w,   z); }
		public static Vector4 zyww(this Vector2 v, float z, float w) { return new Vector4(  z, v.y,   w,   w); }
		public static Vector4 zzxx(this Vector2 v, float z         ) { return new Vector4(  z,   z, v.x, v.x); }
		public static Vector4 zzxy(this Vector2 v, float z         ) { return new Vector4(  z,   z, v.x, v.y); }
		public static Vector4 zzxz(this Vector2 v, float z         ) { return new Vector4(  z,   z, v.x,   z); }
		public static Vector4 zzxw(this Vector2 v, float z, float w) { return new Vector4(  z,   z, v.x,   w); }
		public static Vector4 zzyx(this Vector2 v, float z         ) { return new Vector4(  z,   z, v.y, v.x); }
		public static Vector4 zzyy(this Vector2 v, float z         ) { return new Vector4(  z,   z, v.y, v.y); }
		public static Vector4 zzyz(this Vector2 v, float z         ) { return new Vector4(  z,   z, v.y,   z); }
		public static Vector4 zzyw(this Vector2 v, float z, float w) { return new Vector4(  z,   z, v.y,   w); }
		public static Vector4 zzzx(this Vector2 v, float z         ) { return new Vector4(  z,   z,   z, v.x); }
		public static Vector4 zzzy(this Vector2 v, float z         ) { return new Vector4(  z,   z,   z, v.y); }
		public static Vector4 zzzz(this Vector2 v, float z         ) { return new Vector4(  z,   z,   z,   z); }
		public static Vector4 zzzw(this Vector2 v, float z, float w) { return new Vector4(  z,   z,   z,   w); }
		public static Vector4 zzwx(this Vector2 v, float z, float w) { return new Vector4(  z,   z,   w, v.x); }
		public static Vector4 zzwy(this Vector2 v, float z, float w) { return new Vector4(  z,   z,   w, v.y); }
		public static Vector4 zzwz(this Vector2 v, float z, float w) { return new Vector4(  z,   z,   w,   z); }
		public static Vector4 zzww(this Vector2 v, float z, float w) { return new Vector4(  z,   z,   w,   w); }
		public static Vector4 zwxx(this Vector2 v, float z, float w) { return new Vector4(  z,   w, v.x, v.x); }
		public static Vector4 zwxy(this Vector2 v, float z, float w) { return new Vector4(  z,   w, v.x, v.y); }
		public static Vector4 zwxz(this Vector2 v, float z, float w) { return new Vector4(  z,   w, v.x,   z); }
		public static Vector4 zwxw(this Vector2 v, float z, float w) { return new Vector4(  z,   w, v.x,   w); }
		public static Vector4 zwyx(this Vector2 v, float z, float w) { return new Vector4(  z,   w, v.y, v.x); }
		public static Vector4 zwyy(this Vector2 v, float z, float w) { return new Vector4(  z,   w, v.y, v.y); }
		public static Vector4 zwyz(this Vector2 v, float z, float w) { return new Vector4(  z,   w, v.y,   z); }
		public static Vector4 zwyw(this Vector2 v, float z, float w) { return new Vector4(  z,   w, v.y,   w); }
		public static Vector4 zwzx(this Vector2 v, float z, float w) { return new Vector4(  z,   w,   z, v.x); }
		public static Vector4 zwzy(this Vector2 v, float z, float w) { return new Vector4(  z,   w,   z, v.y); }
		public static Vector4 zwzz(this Vector2 v, float z, float w) { return new Vector4(  z,   w,   z,   z); }
		public static Vector4 zwzw(this Vector2 v, float z, float w) { return new Vector4(  z,   w,   z,   w); }
		public static Vector4 zwwx(this Vector2 v, float z, float w) { return new Vector4(  z,   w,   w, v.x); }
		public static Vector4 zwwy(this Vector2 v, float z, float w) { return new Vector4(  z,   w,   w, v.y); }
		public static Vector4 zwwz(this Vector2 v, float z, float w) { return new Vector4(  z,   w,   w,   z); }
		public static Vector4 zwww(this Vector2 v, float z, float w) { return new Vector4(  z,   w,   w,   w); }
		public static Vector4 wxxx(this Vector2 v, float w         ) { return new Vector4(  w, v.x, v.x, v.x); }
		public static Vector4 wxxy(this Vector2 v, float w         ) { return new Vector4(  w, v.x, v.x, v.y); }
		public static Vector4 wxxz(this Vector2 v, float z, float w) { return new Vector4(  w, v.x, v.x,   z); }
		public static Vector4 wxxw(this Vector2 v, float w         ) { return new Vector4(  w, v.x, v.x,   w); }
		public static Vector4 wxyx(this Vector2 v, float w         ) { return new Vector4(  w, v.x, v.y, v.x); }
		public static Vector4 wxyy(this Vector2 v, float w         ) { return new Vector4(  w, v.x, v.y, v.y); }
		public static Vector4 wxyz(this Vector2 v, float z, float w) { return new Vector4(  w, v.x, v.y,   z); }
		public static Vector4 wxyw(this Vector2 v, float w         ) { return new Vector4(  w, v.x, v.y,   w); }
		public static Vector4 wxzx(this Vector2 v, float z, float w) { return new Vector4(  w, v.x,   z, v.x); }
		public static Vector4 wxzy(this Vector2 v, float z, float w) { return new Vector4(  w, v.x,   z, v.y); }
		public static Vector4 wxzz(this Vector2 v, float z, float w) { return new Vector4(  w, v.x,   z,   z); }
		public static Vector4 wxzw(this Vector2 v, float z, float w) { return new Vector4(  w, v.x,   z,   w); }
		public static Vector4 wxwx(this Vector2 v, float w         ) { return new Vector4(  w, v.x,   w, v.x); }
		public static Vector4 wxwy(this Vector2 v, float w         ) { return new Vector4(  w, v.x,   w, v.y); }
		public static Vector4 wxwz(this Vector2 v, float z, float w) { return new Vector4(  w, v.x,   w,   z); }
		public static Vector4 wxww(this Vector2 v, float w         ) { return new Vector4(  w, v.x,   w,   w); }
		public static Vector4 wyxx(this Vector2 v, float w         ) { return new Vector4(  w, v.y, v.x, v.x); }
		public static Vector4 wyxy(this Vector2 v, float w         ) { return new Vector4(  w, v.y, v.x, v.y); }
		public static Vector4 wyxz(this Vector2 v, float z, float w) { return new Vector4(  w, v.y, v.x,   z); }
		public static Vector4 wyxw(this Vector2 v, float w         ) { return new Vector4(  w, v.y, v.x,   w); }
		public static Vector4 wyyx(this Vector2 v, float w         ) { return new Vector4(  w, v.y, v.y, v.x); }
		public static Vector4 wyyy(this Vector2 v, float w         ) { return new Vector4(  w, v.y, v.y, v.y); }
		public static Vector4 wyyz(this Vector2 v, float z, float w) { return new Vector4(  w, v.y, v.y,   z); }
		public static Vector4 wyyw(this Vector2 v, float w         ) { return new Vector4(  w, v.y, v.y,   w); }
		public static Vector4 wyzx(this Vector2 v, float z, float w) { return new Vector4(  w, v.y,   z, v.x); }
		public static Vector4 wyzy(this Vector2 v, float z, float w) { return new Vector4(  w, v.y,   z, v.y); }
		public static Vector4 wyzz(this Vector2 v, float z, float w) { return new Vector4(  w, v.y,   z,   z); }
		public static Vector4 wyzw(this Vector2 v, float z, float w) { return new Vector4(  w, v.y,   z,   w); }
		public static Vector4 wywx(this Vector2 v, float w         ) { return new Vector4(  w, v.y,   w, v.x); }
		public static Vector4 wywy(this Vector2 v, float w         ) { return new Vector4(  w, v.y,   w, v.y); }
		public static Vector4 wywz(this Vector2 v, float z, float w) { return new Vector4(  w, v.y,   w,   z); }
		public static Vector4 wyww(this Vector2 v, float w         ) { return new Vector4(  w, v.y,   w,   w); }
		public static Vector4 wzxx(this Vector2 v, float z, float w) { return new Vector4(  w,   z, v.x, v.x); }
		public static Vector4 wzxy(this Vector2 v, float z, float w) { return new Vector4(  w,   z, v.x, v.y); }
		public static Vector4 wzxz(this Vector2 v, float z, float w) { return new Vector4(  w,   z, v.x,   z); }
		public static Vector4 wzxw(this Vector2 v, float z, float w) { return new Vector4(  w,   z, v.x,   w); }
		public static Vector4 wzyx(this Vector2 v, float z, float w) { return new Vector4(  w,   z, v.y, v.x); }
		public static Vector4 wzyy(this Vector2 v, float z, float w) { return new Vector4(  w,   z, v.y, v.y); }
		public static Vector4 wzyz(this Vector2 v, float z, float w) { return new Vector4(  w,   z, v.y,   z); }
		public static Vector4 wzyw(this Vector2 v, float z, float w) { return new Vector4(  w,   z, v.y,   w); }
		public static Vector4 wzzx(this Vector2 v, float z, float w) { return new Vector4(  w,   z,   z, v.x); }
		public static Vector4 wzzy(this Vector2 v, float z, float w) { return new Vector4(  w,   z,   z, v.y); }
		public static Vector4 wzzz(this Vector2 v, float z, float w) { return new Vector4(  w,   z,   z,   z); }
		public static Vector4 wzzw(this Vector2 v, float z, float w) { return new Vector4(  w,   z,   z,   w); }
		public static Vector4 wzwx(this Vector2 v, float z, float w) { return new Vector4(  w,   z,   w, v.x); }
		public static Vector4 wzwy(this Vector2 v, float z, float w) { return new Vector4(  w,   z,   w, v.y); }
		public static Vector4 wzwz(this Vector2 v, float z, float w) { return new Vector4(  w,   z,   w,   z); }
		public static Vector4 wzww(this Vector2 v, float z, float w) { return new Vector4(  w,   z,   w,   w); }
		public static Vector4 wwxx(this Vector2 v, float w         ) { return new Vector4(  w,   w, v.x, v.x); }
		public static Vector4 wwxy(this Vector2 v, float w         ) { return new Vector4(  w,   w, v.x, v.y); }
		public static Vector4 wwxz(this Vector2 v, float z, float w) { return new Vector4(  w,   w, v.x,   z); }
		public static Vector4 wwxw(this Vector2 v, float w         ) { return new Vector4(  w,   w, v.x,   w); }
		public static Vector4 wwyx(this Vector2 v, float w         ) { return new Vector4(  w,   w, v.y, v.x); }
		public static Vector4 wwyy(this Vector2 v, float w         ) { return new Vector4(  w,   w, v.y, v.y); }
		public static Vector4 wwyz(this Vector2 v, float z, float w) { return new Vector4(  w,   w, v.y,   z); }
		public static Vector4 wwyw(this Vector2 v, float w         ) { return new Vector4(  w,   w, v.y,   w); }
		public static Vector4 wwzx(this Vector2 v, float z, float w) { return new Vector4(  w,   w,   z, v.x); }
		public static Vector4 wwzy(this Vector2 v, float z, float w) { return new Vector4(  w,   w,   z, v.y); }
		public static Vector4 wwzz(this Vector2 v, float z, float w) { return new Vector4(  w,   w,   z,   z); }
		public static Vector4 wwzw(this Vector2 v, float z, float w) { return new Vector4(  w,   w,   z,   w); }
		public static Vector4 wwwx(this Vector2 v, float w         ) { return new Vector4(  w,   w,   w, v.x); }
		public static Vector4 wwwy(this Vector2 v, float w         ) { return new Vector4(  w,   w,   w, v.y); }
		public static Vector4 wwwz(this Vector2 v, float z, float w) { return new Vector4(  w,   w,   w,   z); }
		public static Vector4 wwww(this Vector2 v, float w         ) { return new Vector4(  w,   w,   w,   w); }
	}


	public static class SwizzleVector3To4
	{
		public static Vector4 xxxx(this Vector3 v         ) { return new Vector4(v.x, v.x, v.x, v.x); }
		public static Vector4 xxxy(this Vector3 v         ) { return new Vector4(v.x, v.x, v.x, v.y); }
		public static Vector4 xxxz(this Vector3 v         ) { return new Vector4(v.x, v.x, v.x, v.z); }
		public static Vector4 xxxw(this Vector3 v, float w) { return new Vector4(v.x, v.x, v.x,   w); }
		public static Vector4 xxyx(this Vector3 v         ) { return new Vector4(v.x, v.x, v.y, v.x); }
		public static Vector4 xxyy(this Vector3 v         ) { return new Vector4(v.x, v.x, v.y, v.y); }
		public static Vector4 xxyz(this Vector3 v         ) { return new Vector4(v.x, v.x, v.y, v.z); }
		public static Vector4 xxyw(this Vector3 v, float w) { return new Vector4(v.x, v.x, v.y,   w); }
		public static Vector4 xxzx(this Vector3 v         ) { return new Vector4(v.x, v.x, v.z, v.x); }
		public static Vector4 xxzy(this Vector3 v         ) { return new Vector4(v.x, v.x, v.z, v.y); }
		public static Vector4 xxzz(this Vector3 v         ) { return new Vector4(v.x, v.x, v.z, v.z); }
		public static Vector4 xxzw(this Vector3 v, float w) { return new Vector4(v.x, v.x, v.z,   w); }
		public static Vector4 xxwx(this Vector3 v, float w) { return new Vector4(v.x, v.x,   w, v.x); }
		public static Vector4 xxwy(this Vector3 v, float w) { return new Vector4(v.x, v.x,   w, v.y); }
		public static Vector4 xxwz(this Vector3 v, float w) { return new Vector4(v.x, v.x,   w, v.z); }
		public static Vector4 xxww(this Vector3 v, float w) { return new Vector4(v.x, v.x,   w,   w); }
		public static Vector4 xyxx(this Vector3 v         ) { return new Vector4(v.x, v.y, v.x, v.x); }
		public static Vector4 xyxy(this Vector3 v         ) { return new Vector4(v.x, v.y, v.x, v.y); }
		public static Vector4 xyxz(this Vector3 v         ) { return new Vector4(v.x, v.y, v.x, v.z); }
		public static Vector4 xyxw(this Vector3 v, float w) { return new Vector4(v.x, v.y, v.x,   w); }
		public static Vector4 xyyx(this Vector3 v         ) { return new Vector4(v.x, v.y, v.y, v.x); }
		public static Vector4 xyyy(this Vector3 v         ) { return new Vector4(v.x, v.y, v.y, v.y); }
		public static Vector4 xyyz(this Vector3 v         ) { return new Vector4(v.x, v.y, v.y, v.z); }
		public static Vector4 xyyw(this Vector3 v, float w) { return new Vector4(v.x, v.y, v.y,   w); }
		public static Vector4 xyzx(this Vector3 v         ) { return new Vector4(v.x, v.y, v.z, v.x); }
		public static Vector4 xyzy(this Vector3 v         ) { return new Vector4(v.x, v.y, v.z, v.y); }
		public static Vector4 xyzz(this Vector3 v         ) { return new Vector4(v.x, v.y, v.z, v.z); }
		public static Vector4 xyzw(this Vector3 v, float w) { return new Vector4(v.x, v.y, v.z,   w); }
		public static Vector4 xywx(this Vector3 v, float w) { return new Vector4(v.x, v.y,   w, v.x); }
		public static Vector4 xywy(this Vector3 v, float w) { return new Vector4(v.x, v.y,   w, v.y); }
		public static Vector4 xywz(this Vector3 v, float w) { return new Vector4(v.x, v.y,   w, v.z); }
		public static Vector4 xyww(this Vector3 v, float w) { return new Vector4(v.x, v.y,   w,   w); }
		public static Vector4 xzxx(this Vector3 v         ) { return new Vector4(v.x, v.z, v.x, v.x); }
		public static Vector4 xzxy(this Vector3 v         ) { return new Vector4(v.x, v.z, v.x, v.y); }
		public static Vector4 xzxz(this Vector3 v         ) { return new Vector4(v.x, v.z, v.x, v.z); }
		public static Vector4 xzxw(this Vector3 v, float w) { return new Vector4(v.x, v.z, v.x,   w); }
		public static Vector4 xzyx(this Vector3 v         ) { return new Vector4(v.x, v.z, v.y, v.x); }
		public static Vector4 xzyy(this Vector3 v         ) { return new Vector4(v.x, v.z, v.y, v.y); }
		public static Vector4 xzyz(this Vector3 v         ) { return new Vector4(v.x, v.z, v.y, v.z); }
		public static Vector4 xzyw(this Vector3 v, float w) { return new Vector4(v.x, v.z, v.y,   w); }
		public static Vector4 xzzx(this Vector3 v         ) { return new Vector4(v.x, v.z, v.z, v.x); }
		public static Vector4 xzzy(this Vector3 v         ) { return new Vector4(v.x, v.z, v.z, v.y); }
		public static Vector4 xzzz(this Vector3 v         ) { return new Vector4(v.x, v.z, v.z, v.z); }
		public static Vector4 xzzw(this Vector3 v, float w) { return new Vector4(v.x, v.z, v.z,   w); }
		public static Vector4 xzwx(this Vector3 v, float w) { return new Vector4(v.x, v.z,   w, v.x); }
		public static Vector4 xzwy(this Vector3 v, float w) { return new Vector4(v.x, v.z,   w, v.y); }
		public static Vector4 xzwz(this Vector3 v, float w) { return new Vector4(v.x, v.z,   w, v.z); }
		public static Vector4 xzww(this Vector3 v, float w) { return new Vector4(v.x, v.z,   w,   w); }
		public static Vector4 xwxx(this Vector3 v, float w) { return new Vector4(v.x,   w, v.x, v.x); }
		public static Vector4 xwxy(this Vector3 v, float w) { return new Vector4(v.x,   w, v.x, v.y); }
		public static Vector4 xwxz(this Vector3 v, float w) { return new Vector4(v.x,   w, v.x, v.z); }
		public static Vector4 xwxw(this Vector3 v, float w) { return new Vector4(v.x,   w, v.x,   w); }
		public static Vector4 xwyx(this Vector3 v, float w) { return new Vector4(v.x,   w, v.y, v.x); }
		public static Vector4 xwyy(this Vector3 v, float w) { return new Vector4(v.x,   w, v.y, v.y); }
		public static Vector4 xwyz(this Vector3 v, float w) { return new Vector4(v.x,   w, v.y, v.z); }
		public static Vector4 xwyw(this Vector3 v, float w) { return new Vector4(v.x,   w, v.y,   w); }
		public static Vector4 xwzx(this Vector3 v, float w) { return new Vector4(v.x,   w, v.z, v.x); }
		public static Vector4 xwzy(this Vector3 v, float w) { return new Vector4(v.x,   w, v.z, v.y); }
		public static Vector4 xwzz(this Vector3 v, float w) { return new Vector4(v.x,   w, v.z, v.z); }
		public static Vector4 xwzw(this Vector3 v, float w) { return new Vector4(v.x,   w, v.z,   w); }
		public static Vector4 xwwx(this Vector3 v, float w) { return new Vector4(v.x,   w,   w, v.x); }
		public static Vector4 xwwy(this Vector3 v, float w) { return new Vector4(v.x,   w,   w, v.y); }
		public static Vector4 xwwz(this Vector3 v, float w) { return new Vector4(v.x,   w,   w, v.z); }
		public static Vector4 xwww(this Vector3 v, float w) { return new Vector4(v.x,   w,   w,   w); }
		public static Vector4 yxxx(this Vector3 v         ) { return new Vector4(v.y, v.x, v.x, v.x); }
		public static Vector4 yxxy(this Vector3 v         ) { return new Vector4(v.y, v.x, v.x, v.y); }
		public static Vector4 yxxz(this Vector3 v         ) { return new Vector4(v.y, v.x, v.x, v.z); }
		public static Vector4 yxxw(this Vector3 v, float w) { return new Vector4(v.y, v.x, v.x,   w); }
		public static Vector4 yxyx(this Vector3 v         ) { return new Vector4(v.y, v.x, v.y, v.x); }
		public static Vector4 yxyy(this Vector3 v         ) { return new Vector4(v.y, v.x, v.y, v.y); }
		public static Vector4 yxyz(this Vector3 v         ) { return new Vector4(v.y, v.x, v.y, v.z); }
		public static Vector4 yxyw(this Vector3 v, float w) { return new Vector4(v.y, v.x, v.y,   w); }
		public static Vector4 yxzx(this Vector3 v         ) { return new Vector4(v.y, v.x, v.z, v.x); }
		public static Vector4 yxzy(this Vector3 v         ) { return new Vector4(v.y, v.x, v.z, v.y); }
		public static Vector4 yxzz(this Vector3 v         ) { return new Vector4(v.y, v.x, v.z, v.z); }
		public static Vector4 yxzw(this Vector3 v, float w) { return new Vector4(v.y, v.x, v.z,   w); }
		public static Vector4 yxwx(this Vector3 v, float w) { return new Vector4(v.y, v.x,   w, v.x); }
		public static Vector4 yxwy(this Vector3 v, float w) { return new Vector4(v.y, v.x,   w, v.y); }
		public static Vector4 yxwz(this Vector3 v, float w) { return new Vector4(v.y, v.x,   w, v.z); }
		public static Vector4 yxww(this Vector3 v, float w) { return new Vector4(v.y, v.x,   w,   w); }
		public static Vector4 yyxx(this Vector3 v         ) { return new Vector4(v.y, v.y, v.x, v.x); }
		public static Vector4 yyxy(this Vector3 v         ) { return new Vector4(v.y, v.y, v.x, v.y); }
		public static Vector4 yyxz(this Vector3 v         ) { return new Vector4(v.y, v.y, v.x, v.z); }
		public static Vector4 yyxw(this Vector3 v, float w) { return new Vector4(v.y, v.y, v.x,   w); }
		public static Vector4 yyyx(this Vector3 v         ) { return new Vector4(v.y, v.y, v.y, v.x); }
		public static Vector4 yyyy(this Vector3 v         ) { return new Vector4(v.y, v.y, v.y, v.y); }
		public static Vector4 yyyz(this Vector3 v         ) { return new Vector4(v.y, v.y, v.y, v.z); }
		public static Vector4 yyyw(this Vector3 v, float w) { return new Vector4(v.y, v.y, v.y,   w); }
		public static Vector4 yyzx(this Vector3 v         ) { return new Vector4(v.y, v.y, v.z, v.x); }
		public static Vector4 yyzy(this Vector3 v         ) { return new Vector4(v.y, v.y, v.z, v.y); }
		public static Vector4 yyzz(this Vector3 v         ) { return new Vector4(v.y, v.y, v.z, v.z); }
		public static Vector4 yyzw(this Vector3 v, float w) { return new Vector4(v.y, v.y, v.z,   w); }
		public static Vector4 yywx(this Vector3 v, float w) { return new Vector4(v.y, v.y,   w, v.x); }
		public static Vector4 yywy(this Vector3 v, float w) { return new Vector4(v.y, v.y,   w, v.y); }
		public static Vector4 yywz(this Vector3 v, float w) { return new Vector4(v.y, v.y,   w, v.z); }
		public static Vector4 yyww(this Vector3 v, float w) { return new Vector4(v.y, v.y,   w,   w); }
		public static Vector4 yzxx(this Vector3 v         ) { return new Vector4(v.y, v.z, v.x, v.x); }
		public static Vector4 yzxy(this Vector3 v         ) { return new Vector4(v.y, v.z, v.x, v.y); }
		public static Vector4 yzxz(this Vector3 v         ) { return new Vector4(v.y, v.z, v.x, v.z); }
		public static Vector4 yzxw(this Vector3 v, float w) { return new Vector4(v.y, v.z, v.x,   w); }
		public static Vector4 yzyx(this Vector3 v         ) { return new Vector4(v.y, v.z, v.y, v.x); }
		public static Vector4 yzyy(this Vector3 v         ) { return new Vector4(v.y, v.z, v.y, v.y); }
		public static Vector4 yzyz(this Vector3 v         ) { return new Vector4(v.y, v.z, v.y, v.z); }
		public static Vector4 yzyw(this Vector3 v, float w) { return new Vector4(v.y, v.z, v.y,   w); }
		public static Vector4 yzzx(this Vector3 v         ) { return new Vector4(v.y, v.z, v.z, v.x); }
		public static Vector4 yzzy(this Vector3 v         ) { return new Vector4(v.y, v.z, v.z, v.y); }
		public static Vector4 yzzz(this Vector3 v         ) { return new Vector4(v.y, v.z, v.z, v.z); }
		public static Vector4 yzzw(this Vector3 v, float w) { return new Vector4(v.y, v.z, v.z,   w); }
		public static Vector4 yzwx(this Vector3 v, float w) { return new Vector4(v.y, v.z,   w, v.x); }
		public static Vector4 yzwy(this Vector3 v, float w) { return new Vector4(v.y, v.z,   w, v.y); }
		public static Vector4 yzwz(this Vector3 v, float w) { return new Vector4(v.y, v.z,   w, v.z); }
		public static Vector4 yzww(this Vector3 v, float w) { return new Vector4(v.y, v.z,   w,   w); }
		public static Vector4 ywxx(this Vector3 v, float w) { return new Vector4(v.y,   w, v.x, v.x); }
		public static Vector4 ywxy(this Vector3 v, float w) { return new Vector4(v.y,   w, v.x, v.y); }
		public static Vector4 ywxz(this Vector3 v, float w) { return new Vector4(v.y,   w, v.x, v.z); }
		public static Vector4 ywxw(this Vector3 v, float w) { return new Vector4(v.y,   w, v.x,   w); }
		public static Vector4 ywyx(this Vector3 v, float w) { return new Vector4(v.y,   w, v.y, v.x); }
		public static Vector4 ywyy(this Vector3 v, float w) { return new Vector4(v.y,   w, v.y, v.y); }
		public static Vector4 ywyz(this Vector3 v, float w) { return new Vector4(v.y,   w, v.y, v.z); }
		public static Vector4 ywyw(this Vector3 v, float w) { return new Vector4(v.y,   w, v.y,   w); }
		public static Vector4 ywzx(this Vector3 v, float w) { return new Vector4(v.y,   w, v.z, v.x); }
		public static Vector4 ywzy(this Vector3 v, float w) { return new Vector4(v.y,   w, v.z, v.y); }
		public static Vector4 ywzz(this Vector3 v, float w) { return new Vector4(v.y,   w, v.z, v.z); }
		public static Vector4 ywzw(this Vector3 v, float w) { return new Vector4(v.y,   w, v.z,   w); }
		public static Vector4 ywwx(this Vector3 v, float w) { return new Vector4(v.y,   w,   w, v.x); }
		public static Vector4 ywwy(this Vector3 v, float w) { return new Vector4(v.y,   w,   w, v.y); }
		public static Vector4 ywwz(this Vector3 v, float w) { return new Vector4(v.y,   w,   w, v.z); }
		public static Vector4 ywww(this Vector3 v, float w) { return new Vector4(v.y,   w,   w,   w); }
		public static Vector4 zxxx(this Vector3 v         ) { return new Vector4(v.z, v.x, v.x, v.x); }
		public static Vector4 zxxy(this Vector3 v         ) { return new Vector4(v.z, v.x, v.x, v.y); }
		public static Vector4 zxxz(this Vector3 v         ) { return new Vector4(v.z, v.x, v.x, v.z); }
		public static Vector4 zxxw(this Vector3 v, float w) { return new Vector4(v.z, v.x, v.x,   w); }
		public static Vector4 zxyx(this Vector3 v         ) { return new Vector4(v.z, v.x, v.y, v.x); }
		public static Vector4 zxyy(this Vector3 v         ) { return new Vector4(v.z, v.x, v.y, v.y); }
		public static Vector4 zxyz(this Vector3 v         ) { return new Vector4(v.z, v.x, v.y, v.z); }
		public static Vector4 zxyw(this Vector3 v, float w) { return new Vector4(v.z, v.x, v.y,   w); }
		public static Vector4 zxzx(this Vector3 v         ) { return new Vector4(v.z, v.x, v.z, v.x); }
		public static Vector4 zxzy(this Vector3 v         ) { return new Vector4(v.z, v.x, v.z, v.y); }
		public static Vector4 zxzz(this Vector3 v         ) { return new Vector4(v.z, v.x, v.z, v.z); }
		public static Vector4 zxzw(this Vector3 v, float w) { return new Vector4(v.z, v.x, v.z,   w); }
		public static Vector4 zxwx(this Vector3 v, float w) { return new Vector4(v.z, v.x,   w, v.x); }
		public static Vector4 zxwy(this Vector3 v, float w) { return new Vector4(v.z, v.x,   w, v.y); }
		public static Vector4 zxwz(this Vector3 v, float w) { return new Vector4(v.z, v.x,   w, v.z); }
		public static Vector4 zxww(this Vector3 v, float w) { return new Vector4(v.z, v.x,   w,   w); }
		public static Vector4 zyxx(this Vector3 v         ) { return new Vector4(v.z, v.y, v.x, v.x); }
		public static Vector4 zyxy(this Vector3 v         ) { return new Vector4(v.z, v.y, v.x, v.y); }
		public static Vector4 zyxz(this Vector3 v         ) { return new Vector4(v.z, v.y, v.x, v.z); }
		public static Vector4 zyxw(this Vector3 v, float w) { return new Vector4(v.z, v.y, v.x,   w); }
		public static Vector4 zyyx(this Vector3 v         ) { return new Vector4(v.z, v.y, v.y, v.x); }
		public static Vector4 zyyy(this Vector3 v         ) { return new Vector4(v.z, v.y, v.y, v.y); }
		public static Vector4 zyyz(this Vector3 v         ) { return new Vector4(v.z, v.y, v.y, v.z); }
		public static Vector4 zyyw(this Vector3 v, float w) { return new Vector4(v.z, v.y, v.y,   w); }
		public static Vector4 zyzx(this Vector3 v         ) { return new Vector4(v.z, v.y, v.z, v.x); }
		public static Vector4 zyzy(this Vector3 v         ) { return new Vector4(v.z, v.y, v.z, v.y); }
		public static Vector4 zyzz(this Vector3 v         ) { return new Vector4(v.z, v.y, v.z, v.z); }
		public static Vector4 zyzw(this Vector3 v, float w) { return new Vector4(v.z, v.y, v.z,   w); }
		public static Vector4 zywx(this Vector3 v, float w) { return new Vector4(v.z, v.y,   w, v.x); }
		public static Vector4 zywy(this Vector3 v, float w) { return new Vector4(v.z, v.y,   w, v.y); }
		public static Vector4 zywz(this Vector3 v, float w) { return new Vector4(v.z, v.y,   w, v.z); }
		public static Vector4 zyww(this Vector3 v, float w) { return new Vector4(v.z, v.y,   w,   w); }
		public static Vector4 zzxx(this Vector3 v         ) { return new Vector4(v.z, v.z, v.x, v.x); }
		public static Vector4 zzxy(this Vector3 v         ) { return new Vector4(v.z, v.z, v.x, v.y); }
		public static Vector4 zzxz(this Vector3 v         ) { return new Vector4(v.z, v.z, v.x, v.z); }
		public static Vector4 zzxw(this Vector3 v, float w) { return new Vector4(v.z, v.z, v.x,   w); }
		public static Vector4 zzyx(this Vector3 v         ) { return new Vector4(v.z, v.z, v.y, v.x); }
		public static Vector4 zzyy(this Vector3 v         ) { return new Vector4(v.z, v.z, v.y, v.y); }
		public static Vector4 zzyz(this Vector3 v         ) { return new Vector4(v.z, v.z, v.y, v.z); }
		public static Vector4 zzyw(this Vector3 v, float w) { return new Vector4(v.z, v.z, v.y,   w); }
		public static Vector4 zzzx(this Vector3 v         ) { return new Vector4(v.z, v.z, v.z, v.x); }
		public static Vector4 zzzy(this Vector3 v         ) { return new Vector4(v.z, v.z, v.z, v.y); }
		public static Vector4 zzzz(this Vector3 v         ) { return new Vector4(v.z, v.z, v.z, v.z); }
		public static Vector4 zzzw(this Vector3 v, float w) { return new Vector4(v.z, v.z, v.z,   w); }
		public static Vector4 zzwx(this Vector3 v, float w) { return new Vector4(v.z, v.z,   w, v.x); }
		public static Vector4 zzwy(this Vector3 v, float w) { return new Vector4(v.z, v.z,   w, v.y); }
		public static Vector4 zzwz(this Vector3 v, float w) { return new Vector4(v.z, v.z,   w, v.z); }
		public static Vector4 zzww(this Vector3 v, float w) { return new Vector4(v.z, v.z,   w,   w); }
		public static Vector4 zwxx(this Vector3 v, float w) { return new Vector4(v.z,   w, v.x, v.x); }
		public static Vector4 zwxy(this Vector3 v, float w) { return new Vector4(v.z,   w, v.x, v.y); }
		public static Vector4 zwxz(this Vector3 v, float w) { return new Vector4(v.z,   w, v.x, v.z); }
		public static Vector4 zwxw(this Vector3 v, float w) { return new Vector4(v.z,   w, v.x,   w); }
		public static Vector4 zwyx(this Vector3 v, float w) { return new Vector4(v.z,   w, v.y, v.x); }
		public static Vector4 zwyy(this Vector3 v, float w) { return new Vector4(v.z,   w, v.y, v.y); }
		public static Vector4 zwyz(this Vector3 v, float w) { return new Vector4(v.z,   w, v.y, v.z); }
		public static Vector4 zwyw(this Vector3 v, float w) { return new Vector4(v.z,   w, v.y,   w); }
		public static Vector4 zwzx(this Vector3 v, float w) { return new Vector4(v.z,   w, v.z, v.x); }
		public static Vector4 zwzy(this Vector3 v, float w) { return new Vector4(v.z,   w, v.z, v.y); }
		public static Vector4 zwzz(this Vector3 v, float w) { return new Vector4(v.z,   w, v.z, v.z); }
		public static Vector4 zwzw(this Vector3 v, float w) { return new Vector4(v.z,   w, v.z,   w); }
		public static Vector4 zwwx(this Vector3 v, float w) { return new Vector4(v.z,   w,   w, v.x); }
		public static Vector4 zwwy(this Vector3 v, float w) { return new Vector4(v.z,   w,   w, v.y); }
		public static Vector4 zwwz(this Vector3 v, float w) { return new Vector4(v.z,   w,   w, v.z); }
		public static Vector4 zwww(this Vector3 v, float w) { return new Vector4(v.z,   w,   w,   w); }
		public static Vector4 wxxx(this Vector3 v, float w) { return new Vector4(  w, v.x, v.x, v.x); }
		public static Vector4 wxxy(this Vector3 v, float w) { return new Vector4(  w, v.x, v.x, v.y); }
		public static Vector4 wxxz(this Vector3 v, float w) { return new Vector4(  w, v.x, v.x, v.z); }
		public static Vector4 wxxw(this Vector3 v, float w) { return new Vector4(  w, v.x, v.x,   w); }
		public static Vector4 wxyx(this Vector3 v, float w) { return new Vector4(  w, v.x, v.y, v.x); }
		public static Vector4 wxyy(this Vector3 v, float w) { return new Vector4(  w, v.x, v.y, v.y); }
		public static Vector4 wxyz(this Vector3 v, float w) { return new Vector4(  w, v.x, v.y, v.z); }
		public static Vector4 wxyw(this Vector3 v, float w) { return new Vector4(  w, v.x, v.y,   w); }
		public static Vector4 wxzx(this Vector3 v, float w) { return new Vector4(  w, v.x, v.z, v.x); }
		public static Vector4 wxzy(this Vector3 v, float w) { return new Vector4(  w, v.x, v.z, v.y); }
		public static Vector4 wxzz(this Vector3 v, float w) { return new Vector4(  w, v.x, v.z, v.z); }
		public static Vector4 wxzw(this Vector3 v, float w) { return new Vector4(  w, v.x, v.z,   w); }
		public static Vector4 wxwx(this Vector3 v, float w) { return new Vector4(  w, v.x,   w, v.x); }
		public static Vector4 wxwy(this Vector3 v, float w) { return new Vector4(  w, v.x,   w, v.y); }
		public static Vector4 wxwz(this Vector3 v, float w) { return new Vector4(  w, v.x,   w, v.z); }
		public static Vector4 wxww(this Vector3 v, float w) { return new Vector4(  w, v.x,   w,   w); }
		public static Vector4 wyxx(this Vector3 v, float w) { return new Vector4(  w, v.y, v.x, v.x); }
		public static Vector4 wyxy(this Vector3 v, float w) { return new Vector4(  w, v.y, v.x, v.y); }
		public static Vector4 wyxz(this Vector3 v, float w) { return new Vector4(  w, v.y, v.x, v.z); }
		public static Vector4 wyxw(this Vector3 v, float w) { return new Vector4(  w, v.y, v.x,   w); }
		public static Vector4 wyyx(this Vector3 v, float w) { return new Vector4(  w, v.y, v.y, v.x); }
		public static Vector4 wyyy(this Vector3 v, float w) { return new Vector4(  w, v.y, v.y, v.y); }
		public static Vector4 wyyz(this Vector3 v, float w) { return new Vector4(  w, v.y, v.y, v.z); }
		public static Vector4 wyyw(this Vector3 v, float w) { return new Vector4(  w, v.y, v.y,   w); }
		public static Vector4 wyzx(this Vector3 v, float w) { return new Vector4(  w, v.y, v.z, v.x); }
		public static Vector4 wyzy(this Vector3 v, float w) { return new Vector4(  w, v.y, v.z, v.y); }
		public static Vector4 wyzz(this Vector3 v, float w) { return new Vector4(  w, v.y, v.z, v.z); }
		public static Vector4 wyzw(this Vector3 v, float w) { return new Vector4(  w, v.y, v.z,   w); }
		public static Vector4 wywx(this Vector3 v, float w) { return new Vector4(  w, v.y,   w, v.x); }
		public static Vector4 wywy(this Vector3 v, float w) { return new Vector4(  w, v.y,   w, v.y); }
		public static Vector4 wywz(this Vector3 v, float w) { return new Vector4(  w, v.y,   w, v.z); }
		public static Vector4 wyww(this Vector3 v, float w) { return new Vector4(  w, v.y,   w,   w); }
		public static Vector4 wzxx(this Vector3 v, float w) { return new Vector4(  w, v.z, v.x, v.x); }
		public static Vector4 wzxy(this Vector3 v, float w) { return new Vector4(  w, v.z, v.x, v.y); }
		public static Vector4 wzxz(this Vector3 v, float w) { return new Vector4(  w, v.z, v.x, v.z); }
		public static Vector4 wzxw(this Vector3 v, float w) { return new Vector4(  w, v.z, v.x,   w); }
		public static Vector4 wzyx(this Vector3 v, float w) { return new Vector4(  w, v.z, v.y, v.x); }
		public static Vector4 wzyy(this Vector3 v, float w) { return new Vector4(  w, v.z, v.y, v.y); }
		public static Vector4 wzyz(this Vector3 v, float w) { return new Vector4(  w, v.z, v.y, v.z); }
		public static Vector4 wzyw(this Vector3 v, float w) { return new Vector4(  w, v.z, v.y,   w); }
		public static Vector4 wzzx(this Vector3 v, float w) { return new Vector4(  w, v.z, v.z, v.x); }
		public static Vector4 wzzy(this Vector3 v, float w) { return new Vector4(  w, v.z, v.z, v.y); }
		public static Vector4 wzzz(this Vector3 v, float w) { return new Vector4(  w, v.z, v.z, v.z); }
		public static Vector4 wzzw(this Vector3 v, float w) { return new Vector4(  w, v.z, v.z,   w); }
		public static Vector4 wzwx(this Vector3 v, float w) { return new Vector4(  w, v.z,   w, v.x); }
		public static Vector4 wzwy(this Vector3 v, float w) { return new Vector4(  w, v.z,   w, v.y); }
		public static Vector4 wzwz(this Vector3 v, float w) { return new Vector4(  w, v.z,   w, v.z); }
		public static Vector4 wzww(this Vector3 v, float w) { return new Vector4(  w, v.z,   w,   w); }
		public static Vector4 wwxx(this Vector3 v, float w) { return new Vector4(  w,   w, v.x, v.x); }
		public static Vector4 wwxy(this Vector3 v, float w) { return new Vector4(  w,   w, v.x, v.y); }
		public static Vector4 wwxz(this Vector3 v, float w) { return new Vector4(  w,   w, v.x, v.z); }
		public static Vector4 wwxw(this Vector3 v, float w) { return new Vector4(  w,   w, v.x,   w); }
		public static Vector4 wwyx(this Vector3 v, float w) { return new Vector4(  w,   w, v.y, v.x); }
		public static Vector4 wwyy(this Vector3 v, float w) { return new Vector4(  w,   w, v.y, v.y); }
		public static Vector4 wwyz(this Vector3 v, float w) { return new Vector4(  w,   w, v.y, v.z); }
		public static Vector4 wwyw(this Vector3 v, float w) { return new Vector4(  w,   w, v.y,   w); }
		public static Vector4 wwzx(this Vector3 v, float w) { return new Vector4(  w,   w, v.z, v.x); }
		public static Vector4 wwzy(this Vector3 v, float w) { return new Vector4(  w,   w, v.z, v.y); }
		public static Vector4 wwzz(this Vector3 v, float w) { return new Vector4(  w,   w, v.z, v.z); }
		public static Vector4 wwzw(this Vector3 v, float w) { return new Vector4(  w,   w, v.z,   w); }
		public static Vector4 wwwx(this Vector3 v, float w) { return new Vector4(  w,   w,   w, v.x); }
		public static Vector4 wwwy(this Vector3 v, float w) { return new Vector4(  w,   w,   w, v.y); }
		public static Vector4 wwwz(this Vector3 v, float w) { return new Vector4(  w,   w,   w, v.z); }
		public static Vector4 wwww(this Vector3 v, float w) { return new Vector4(  w,   w,   w,   w); }
	}


	public static class SwizzleVector4To4
	{
		public static Vector4 xxxx(this Vector4 v) { return new Vector4(v.x, v.x, v.x, v.x); }
		public static Vector4 xxxy(this Vector4 v) { return new Vector4(v.x, v.x, v.x, v.y); }
		public static Vector4 xxxz(this Vector4 v) { return new Vector4(v.x, v.x, v.x, v.z); }
		public static Vector4 xxxw(this Vector4 v) { return new Vector4(v.x, v.x, v.x, v.w); }
		public static Vector4 xxyx(this Vector4 v) { return new Vector4(v.x, v.x, v.y, v.x); }
		public static Vector4 xxyy(this Vector4 v) { return new Vector4(v.x, v.x, v.y, v.y); }
		public static Vector4 xxyz(this Vector4 v) { return new Vector4(v.x, v.x, v.y, v.z); }
		public static Vector4 xxyw(this Vector4 v) { return new Vector4(v.x, v.x, v.y, v.w); }
		public static Vector4 xxzx(this Vector4 v) { return new Vector4(v.x, v.x, v.z, v.x); }
		public static Vector4 xxzy(this Vector4 v) { return new Vector4(v.x, v.x, v.z, v.y); }
		public static Vector4 xxzz(this Vector4 v) { return new Vector4(v.x, v.x, v.z, v.z); }
		public static Vector4 xxzw(this Vector4 v) { return new Vector4(v.x, v.x, v.z, v.w); }
		public static Vector4 xxwx(this Vector4 v) { return new Vector4(v.x, v.x, v.w, v.x); }
		public static Vector4 xxwy(this Vector4 v) { return new Vector4(v.x, v.x, v.w, v.y); }
		public static Vector4 xxwz(this Vector4 v) { return new Vector4(v.x, v.x, v.w, v.z); }
		public static Vector4 xxww(this Vector4 v) { return new Vector4(v.x, v.x, v.w, v.w); }
		public static Vector4 xyxx(this Vector4 v) { return new Vector4(v.x, v.y, v.x, v.x); }
		public static Vector4 xyxy(this Vector4 v) { return new Vector4(v.x, v.y, v.x, v.y); }
		public static Vector4 xyxz(this Vector4 v) { return new Vector4(v.x, v.y, v.x, v.z); }
		public static Vector4 xyxw(this Vector4 v) { return new Vector4(v.x, v.y, v.x, v.w); }
		public static Vector4 xyyx(this Vector4 v) { return new Vector4(v.x, v.y, v.y, v.x); }
		public static Vector4 xyyy(this Vector4 v) { return new Vector4(v.x, v.y, v.y, v.y); }
		public static Vector4 xyyz(this Vector4 v) { return new Vector4(v.x, v.y, v.y, v.z); }
		public static Vector4 xyyw(this Vector4 v) { return new Vector4(v.x, v.y, v.y, v.w); }
		public static Vector4 xyzx(this Vector4 v) { return new Vector4(v.x, v.y, v.z, v.x); }
		public static Vector4 xyzy(this Vector4 v) { return new Vector4(v.x, v.y, v.z, v.y); }
		public static Vector4 xyzz(this Vector4 v) { return new Vector4(v.x, v.y, v.z, v.z); }
		public static Vector4 xyzw(this Vector4 v) { return new Vector4(v.x, v.y, v.z, v.w); }
		public static Vector4 xywx(this Vector4 v) { return new Vector4(v.x, v.y, v.w, v.x); }
		public static Vector4 xywy(this Vector4 v) { return new Vector4(v.x, v.y, v.w, v.y); }
		public static Vector4 xywz(this Vector4 v) { return new Vector4(v.x, v.y, v.w, v.z); }
		public static Vector4 xyww(this Vector4 v) { return new Vector4(v.x, v.y, v.w, v.w); }
		public static Vector4 xzxx(this Vector4 v) { return new Vector4(v.x, v.z, v.x, v.x); }
		public static Vector4 xzxy(this Vector4 v) { return new Vector4(v.x, v.z, v.x, v.y); }
		public static Vector4 xzxz(this Vector4 v) { return new Vector4(v.x, v.z, v.x, v.z); }
		public static Vector4 xzxw(this Vector4 v) { return new Vector4(v.x, v.z, v.x, v.w); }
		public static Vector4 xzyx(this Vector4 v) { return new Vector4(v.x, v.z, v.y, v.x); }
		public static Vector4 xzyy(this Vector4 v) { return new Vector4(v.x, v.z, v.y, v.y); }
		public static Vector4 xzyz(this Vector4 v) { return new Vector4(v.x, v.z, v.y, v.z); }
		public static Vector4 xzyw(this Vector4 v) { return new Vector4(v.x, v.z, v.y, v.w); }
		public static Vector4 xzzx(this Vector4 v) { return new Vector4(v.x, v.z, v.z, v.x); }
		public static Vector4 xzzy(this Vector4 v) { return new Vector4(v.x, v.z, v.z, v.y); }
		public static Vector4 xzzz(this Vector4 v) { return new Vector4(v.x, v.z, v.z, v.z); }
		public static Vector4 xzzw(this Vector4 v) { return new Vector4(v.x, v.z, v.z, v.w); }
		public static Vector4 xzwx(this Vector4 v) { return new Vector4(v.x, v.z, v.w, v.x); }
		public static Vector4 xzwy(this Vector4 v) { return new Vector4(v.x, v.z, v.w, v.y); }
		public static Vector4 xzwz(this Vector4 v) { return new Vector4(v.x, v.z, v.w, v.z); }
		public static Vector4 xzww(this Vector4 v) { return new Vector4(v.x, v.z, v.w, v.w); }
		public static Vector4 xwxx(this Vector4 v) { return new Vector4(v.x, v.w, v.x, v.x); }
		public static Vector4 xwxy(this Vector4 v) { return new Vector4(v.x, v.w, v.x, v.y); }
		public static Vector4 xwxz(this Vector4 v) { return new Vector4(v.x, v.w, v.x, v.z); }
		public static Vector4 xwxw(this Vector4 v) { return new Vector4(v.x, v.w, v.x, v.w); }
		public static Vector4 xwyx(this Vector4 v) { return new Vector4(v.x, v.w, v.y, v.x); }
		public static Vector4 xwyy(this Vector4 v) { return new Vector4(v.x, v.w, v.y, v.y); }
		public static Vector4 xwyz(this Vector4 v) { return new Vector4(v.x, v.w, v.y, v.z); }
		public static Vector4 xwyw(this Vector4 v) { return new Vector4(v.x, v.w, v.y, v.w); }
		public static Vector4 xwzx(this Vector4 v) { return new Vector4(v.x, v.w, v.z, v.x); }
		public static Vector4 xwzy(this Vector4 v) { return new Vector4(v.x, v.w, v.z, v.y); }
		public static Vector4 xwzz(this Vector4 v) { return new Vector4(v.x, v.w, v.z, v.z); }
		public static Vector4 xwzw(this Vector4 v) { return new Vector4(v.x, v.w, v.z, v.w); }
		public static Vector4 xwwx(this Vector4 v) { return new Vector4(v.x, v.w, v.w, v.x); }
		public static Vector4 xwwy(this Vector4 v) { return new Vector4(v.x, v.w, v.w, v.y); }
		public static Vector4 xwwz(this Vector4 v) { return new Vector4(v.x, v.w, v.w, v.z); }
		public static Vector4 xwww(this Vector4 v) { return new Vector4(v.x, v.w, v.w, v.w); }
		public static Vector4 yxxx(this Vector4 v) { return new Vector4(v.y, v.x, v.x, v.x); }
		public static Vector4 yxxy(this Vector4 v) { return new Vector4(v.y, v.x, v.x, v.y); }
		public static Vector4 yxxz(this Vector4 v) { return new Vector4(v.y, v.x, v.x, v.z); }
		public static Vector4 yxxw(this Vector4 v) { return new Vector4(v.y, v.x, v.x, v.w); }
		public static Vector4 yxyx(this Vector4 v) { return new Vector4(v.y, v.x, v.y, v.x); }
		public static Vector4 yxyy(this Vector4 v) { return new Vector4(v.y, v.x, v.y, v.y); }
		public static Vector4 yxyz(this Vector4 v) { return new Vector4(v.y, v.x, v.y, v.z); }
		public static Vector4 yxyw(this Vector4 v) { return new Vector4(v.y, v.x, v.y, v.w); }
		public static Vector4 yxzx(this Vector4 v) { return new Vector4(v.y, v.x, v.z, v.x); }
		public static Vector4 yxzy(this Vector4 v) { return new Vector4(v.y, v.x, v.z, v.y); }
		public static Vector4 yxzz(this Vector4 v) { return new Vector4(v.y, v.x, v.z, v.z); }
		public static Vector4 yxzw(this Vector4 v) { return new Vector4(v.y, v.x, v.z, v.w); }
		public static Vector4 yxwx(this Vector4 v) { return new Vector4(v.y, v.x, v.w, v.x); }
		public static Vector4 yxwy(this Vector4 v) { return new Vector4(v.y, v.x, v.w, v.y); }
		public static Vector4 yxwz(this Vector4 v) { return new Vector4(v.y, v.x, v.w, v.z); }
		public static Vector4 yxww(this Vector4 v) { return new Vector4(v.y, v.x, v.w, v.w); }
		public static Vector4 yyxx(this Vector4 v) { return new Vector4(v.y, v.y, v.x, v.x); }
		public static Vector4 yyxy(this Vector4 v) { return new Vector4(v.y, v.y, v.x, v.y); }
		public static Vector4 yyxz(this Vector4 v) { return new Vector4(v.y, v.y, v.x, v.z); }
		public static Vector4 yyxw(this Vector4 v) { return new Vector4(v.y, v.y, v.x, v.w); }
		public static Vector4 yyyx(this Vector4 v) { return new Vector4(v.y, v.y, v.y, v.x); }
		public static Vector4 yyyy(this Vector4 v) { return new Vector4(v.y, v.y, v.y, v.y); }
		public static Vector4 yyyz(this Vector4 v) { return new Vector4(v.y, v.y, v.y, v.z); }
		public static Vector4 yyyw(this Vector4 v) { return new Vector4(v.y, v.y, v.y, v.w); }
		public static Vector4 yyzx(this Vector4 v) { return new Vector4(v.y, v.y, v.z, v.x); }
		public static Vector4 yyzy(this Vector4 v) { return new Vector4(v.y, v.y, v.z, v.y); }
		public static Vector4 yyzz(this Vector4 v) { return new Vector4(v.y, v.y, v.z, v.z); }
		public static Vector4 yyzw(this Vector4 v) { return new Vector4(v.y, v.y, v.z, v.w); }
		public static Vector4 yywx(this Vector4 v) { return new Vector4(v.y, v.y, v.w, v.x); }
		public static Vector4 yywy(this Vector4 v) { return new Vector4(v.y, v.y, v.w, v.y); }
		public static Vector4 yywz(this Vector4 v) { return new Vector4(v.y, v.y, v.w, v.z); }
		public static Vector4 yyww(this Vector4 v) { return new Vector4(v.y, v.y, v.w, v.w); }
		public static Vector4 yzxx(this Vector4 v) { return new Vector4(v.y, v.z, v.x, v.x); }
		public static Vector4 yzxy(this Vector4 v) { return new Vector4(v.y, v.z, v.x, v.y); }
		public static Vector4 yzxz(this Vector4 v) { return new Vector4(v.y, v.z, v.x, v.z); }
		public static Vector4 yzxw(this Vector4 v) { return new Vector4(v.y, v.z, v.x, v.w); }
		public static Vector4 yzyx(this Vector4 v) { return new Vector4(v.y, v.z, v.y, v.x); }
		public static Vector4 yzyy(this Vector4 v) { return new Vector4(v.y, v.z, v.y, v.y); }
		public static Vector4 yzyz(this Vector4 v) { return new Vector4(v.y, v.z, v.y, v.z); }
		public static Vector4 yzyw(this Vector4 v) { return new Vector4(v.y, v.z, v.y, v.w); }
		public static Vector4 yzzx(this Vector4 v) { return new Vector4(v.y, v.z, v.z, v.x); }
		public static Vector4 yzzy(this Vector4 v) { return new Vector4(v.y, v.z, v.z, v.y); }
		public static Vector4 yzzz(this Vector4 v) { return new Vector4(v.y, v.z, v.z, v.z); }
		public static Vector4 yzzw(this Vector4 v) { return new Vector4(v.y, v.z, v.z, v.w); }
		public static Vector4 yzwx(this Vector4 v) { return new Vector4(v.y, v.z, v.w, v.x); }
		public static Vector4 yzwy(this Vector4 v) { return new Vector4(v.y, v.z, v.w, v.y); }
		public static Vector4 yzwz(this Vector4 v) { return new Vector4(v.y, v.z, v.w, v.z); }
		public static Vector4 yzww(this Vector4 v) { return new Vector4(v.y, v.z, v.w, v.w); }
		public static Vector4 ywxx(this Vector4 v) { return new Vector4(v.y, v.w, v.x, v.x); }
		public static Vector4 ywxy(this Vector4 v) { return new Vector4(v.y, v.w, v.x, v.y); }
		public static Vector4 ywxz(this Vector4 v) { return new Vector4(v.y, v.w, v.x, v.z); }
		public static Vector4 ywxw(this Vector4 v) { return new Vector4(v.y, v.w, v.x, v.w); }
		public static Vector4 ywyx(this Vector4 v) { return new Vector4(v.y, v.w, v.y, v.x); }
		public static Vector4 ywyy(this Vector4 v) { return new Vector4(v.y, v.w, v.y, v.y); }
		public static Vector4 ywyz(this Vector4 v) { return new Vector4(v.y, v.w, v.y, v.z); }
		public static Vector4 ywyw(this Vector4 v) { return new Vector4(v.y, v.w, v.y, v.w); }
		public static Vector4 ywzx(this Vector4 v) { return new Vector4(v.y, v.w, v.z, v.x); }
		public static Vector4 ywzy(this Vector4 v) { return new Vector4(v.y, v.w, v.z, v.y); }
		public static Vector4 ywzz(this Vector4 v) { return new Vector4(v.y, v.w, v.z, v.z); }
		public static Vector4 ywzw(this Vector4 v) { return new Vector4(v.y, v.w, v.z, v.w); }
		public static Vector4 ywwx(this Vector4 v) { return new Vector4(v.y, v.w, v.w, v.x); }
		public static Vector4 ywwy(this Vector4 v) { return new Vector4(v.y, v.w, v.w, v.y); }
		public static Vector4 ywwz(this Vector4 v) { return new Vector4(v.y, v.w, v.w, v.z); }
		public static Vector4 ywww(this Vector4 v) { return new Vector4(v.y, v.w, v.w, v.w); }
		public static Vector4 zxxx(this Vector4 v) { return new Vector4(v.z, v.x, v.x, v.x); }
		public static Vector4 zxxy(this Vector4 v) { return new Vector4(v.z, v.x, v.x, v.y); }
		public static Vector4 zxxz(this Vector4 v) { return new Vector4(v.z, v.x, v.x, v.z); }
		public static Vector4 zxxw(this Vector4 v) { return new Vector4(v.z, v.x, v.x, v.w); }
		public static Vector4 zxyx(this Vector4 v) { return new Vector4(v.z, v.x, v.y, v.x); }
		public static Vector4 zxyy(this Vector4 v) { return new Vector4(v.z, v.x, v.y, v.y); }
		public static Vector4 zxyz(this Vector4 v) { return new Vector4(v.z, v.x, v.y, v.z); }
		public static Vector4 zxyw(this Vector4 v) { return new Vector4(v.z, v.x, v.y, v.w); }
		public static Vector4 zxzx(this Vector4 v) { return new Vector4(v.z, v.x, v.z, v.x); }
		public static Vector4 zxzy(this Vector4 v) { return new Vector4(v.z, v.x, v.z, v.y); }
		public static Vector4 zxzz(this Vector4 v) { return new Vector4(v.z, v.x, v.z, v.z); }
		public static Vector4 zxzw(this Vector4 v) { return new Vector4(v.z, v.x, v.z, v.w); }
		public static Vector4 zxwx(this Vector4 v) { return new Vector4(v.z, v.x, v.w, v.x); }
		public static Vector4 zxwy(this Vector4 v) { return new Vector4(v.z, v.x, v.w, v.y); }
		public static Vector4 zxwz(this Vector4 v) { return new Vector4(v.z, v.x, v.w, v.z); }
		public static Vector4 zxww(this Vector4 v) { return new Vector4(v.z, v.x, v.w, v.w); }
		public static Vector4 zyxx(this Vector4 v) { return new Vector4(v.z, v.y, v.x, v.x); }
		public static Vector4 zyxy(this Vector4 v) { return new Vector4(v.z, v.y, v.x, v.y); }
		public static Vector4 zyxz(this Vector4 v) { return new Vector4(v.z, v.y, v.x, v.z); }
		public static Vector4 zyxw(this Vector4 v) { return new Vector4(v.z, v.y, v.x, v.w); }
		public static Vector4 zyyx(this Vector4 v) { return new Vector4(v.z, v.y, v.y, v.x); }
		public static Vector4 zyyy(this Vector4 v) { return new Vector4(v.z, v.y, v.y, v.y); }
		public static Vector4 zyyz(this Vector4 v) { return new Vector4(v.z, v.y, v.y, v.z); }
		public static Vector4 zyyw(this Vector4 v) { return new Vector4(v.z, v.y, v.y, v.w); }
		public static Vector4 zyzx(this Vector4 v) { return new Vector4(v.z, v.y, v.z, v.x); }
		public static Vector4 zyzy(this Vector4 v) { return new Vector4(v.z, v.y, v.z, v.y); }
		public static Vector4 zyzz(this Vector4 v) { return new Vector4(v.z, v.y, v.z, v.z); }
		public static Vector4 zyzw(this Vector4 v) { return new Vector4(v.z, v.y, v.z, v.w); }
		public static Vector4 zywx(this Vector4 v) { return new Vector4(v.z, v.y, v.w, v.x); }
		public static Vector4 zywy(this Vector4 v) { return new Vector4(v.z, v.y, v.w, v.y); }
		public static Vector4 zywz(this Vector4 v) { return new Vector4(v.z, v.y, v.w, v.z); }
		public static Vector4 zyww(this Vector4 v) { return new Vector4(v.z, v.y, v.w, v.w); }
		public static Vector4 zzxx(this Vector4 v) { return new Vector4(v.z, v.z, v.x, v.x); }
		public static Vector4 zzxy(this Vector4 v) { return new Vector4(v.z, v.z, v.x, v.y); }
		public static Vector4 zzxz(this Vector4 v) { return new Vector4(v.z, v.z, v.x, v.z); }
		public static Vector4 zzxw(this Vector4 v) { return new Vector4(v.z, v.z, v.x, v.w); }
		public static Vector4 zzyx(this Vector4 v) { return new Vector4(v.z, v.z, v.y, v.x); }
		public static Vector4 zzyy(this Vector4 v) { return new Vector4(v.z, v.z, v.y, v.y); }
		public static Vector4 zzyz(this Vector4 v) { return new Vector4(v.z, v.z, v.y, v.z); }
		public static Vector4 zzyw(this Vector4 v) { return new Vector4(v.z, v.z, v.y, v.w); }
		public static Vector4 zzzx(this Vector4 v) { return new Vector4(v.z, v.z, v.z, v.x); }
		public static Vector4 zzzy(this Vector4 v) { return new Vector4(v.z, v.z, v.z, v.y); }
		public static Vector4 zzzz(this Vector4 v) { return new Vector4(v.z, v.z, v.z, v.z); }
		public static Vector4 zzzw(this Vector4 v) { return new Vector4(v.z, v.z, v.z, v.w); }
		public static Vector4 zzwx(this Vector4 v) { return new Vector4(v.z, v.z, v.w, v.x); }
		public static Vector4 zzwy(this Vector4 v) { return new Vector4(v.z, v.z, v.w, v.y); }
		public static Vector4 zzwz(this Vector4 v) { return new Vector4(v.z, v.z, v.w, v.z); }
		public static Vector4 zzww(this Vector4 v) { return new Vector4(v.z, v.z, v.w, v.w); }
		public static Vector4 zwxx(this Vector4 v) { return new Vector4(v.z, v.w, v.x, v.x); }
		public static Vector4 zwxy(this Vector4 v) { return new Vector4(v.z, v.w, v.x, v.y); }
		public static Vector4 zwxz(this Vector4 v) { return new Vector4(v.z, v.w, v.x, v.z); }
		public static Vector4 zwxw(this Vector4 v) { return new Vector4(v.z, v.w, v.x, v.w); }
		public static Vector4 zwyx(this Vector4 v) { return new Vector4(v.z, v.w, v.y, v.x); }
		public static Vector4 zwyy(this Vector4 v) { return new Vector4(v.z, v.w, v.y, v.y); }
		public static Vector4 zwyz(this Vector4 v) { return new Vector4(v.z, v.w, v.y, v.z); }
		public static Vector4 zwyw(this Vector4 v) { return new Vector4(v.z, v.w, v.y, v.w); }
		public static Vector4 zwzx(this Vector4 v) { return new Vector4(v.z, v.w, v.z, v.x); }
		public static Vector4 zwzy(this Vector4 v) { return new Vector4(v.z, v.w, v.z, v.y); }
		public static Vector4 zwzz(this Vector4 v) { return new Vector4(v.z, v.w, v.z, v.z); }
		public static Vector4 zwzw(this Vector4 v) { return new Vector4(v.z, v.w, v.z, v.w); }
		public static Vector4 zwwx(this Vector4 v) { return new Vector4(v.z, v.w, v.w, v.x); }
		public static Vector4 zwwy(this Vector4 v) { return new Vector4(v.z, v.w, v.w, v.y); }
		public static Vector4 zwwz(this Vector4 v) { return new Vector4(v.z, v.w, v.w, v.z); }
		public static Vector4 zwww(this Vector4 v) { return new Vector4(v.z, v.w, v.w, v.w); }
		public static Vector4 wxxx(this Vector4 v) { return new Vector4(v.w, v.x, v.x, v.x); }
		public static Vector4 wxxy(this Vector4 v) { return new Vector4(v.w, v.x, v.x, v.y); }
		public static Vector4 wxxz(this Vector4 v) { return new Vector4(v.w, v.x, v.x, v.z); }
		public static Vector4 wxxw(this Vector4 v) { return new Vector4(v.w, v.x, v.x, v.w); }
		public static Vector4 wxyx(this Vector4 v) { return new Vector4(v.w, v.x, v.y, v.x); }
		public static Vector4 wxyy(this Vector4 v) { return new Vector4(v.w, v.x, v.y, v.y); }
		public static Vector4 wxyz(this Vector4 v) { return new Vector4(v.w, v.x, v.y, v.z); }
		public static Vector4 wxyw(this Vector4 v) { return new Vector4(v.w, v.x, v.y, v.w); }
		public static Vector4 wxzx(this Vector4 v) { return new Vector4(v.w, v.x, v.z, v.x); }
		public static Vector4 wxzy(this Vector4 v) { return new Vector4(v.w, v.x, v.z, v.y); }
		public static Vector4 wxzz(this Vector4 v) { return new Vector4(v.w, v.x, v.z, v.z); }
		public static Vector4 wxzw(this Vector4 v) { return new Vector4(v.w, v.x, v.z, v.w); }
		public static Vector4 wxwx(this Vector4 v) { return new Vector4(v.w, v.x, v.w, v.x); }
		public static Vector4 wxwy(this Vector4 v) { return new Vector4(v.w, v.x, v.w, v.y); }
		public static Vector4 wxwz(this Vector4 v) { return new Vector4(v.w, v.x, v.w, v.z); }
		public static Vector4 wxww(this Vector4 v) { return new Vector4(v.w, v.x, v.w, v.w); }
		public static Vector4 wyxx(this Vector4 v) { return new Vector4(v.w, v.y, v.x, v.x); }
		public static Vector4 wyxy(this Vector4 v) { return new Vector4(v.w, v.y, v.x, v.y); }
		public static Vector4 wyxz(this Vector4 v) { return new Vector4(v.w, v.y, v.x, v.z); }
		public static Vector4 wyxw(this Vector4 v) { return new Vector4(v.w, v.y, v.x, v.w); }
		public static Vector4 wyyx(this Vector4 v) { return new Vector4(v.w, v.y, v.y, v.x); }
		public static Vector4 wyyy(this Vector4 v) { return new Vector4(v.w, v.y, v.y, v.y); }
		public static Vector4 wyyz(this Vector4 v) { return new Vector4(v.w, v.y, v.y, v.z); }
		public static Vector4 wyyw(this Vector4 v) { return new Vector4(v.w, v.y, v.y, v.w); }
		public static Vector4 wyzx(this Vector4 v) { return new Vector4(v.w, v.y, v.z, v.x); }
		public static Vector4 wyzy(this Vector4 v) { return new Vector4(v.w, v.y, v.z, v.y); }
		public static Vector4 wyzz(this Vector4 v) { return new Vector4(v.w, v.y, v.z, v.z); }
		public static Vector4 wyzw(this Vector4 v) { return new Vector4(v.w, v.y, v.z, v.w); }
		public static Vector4 wywx(this Vector4 v) { return new Vector4(v.w, v.y, v.w, v.x); }
		public static Vector4 wywy(this Vector4 v) { return new Vector4(v.w, v.y, v.w, v.y); }
		public static Vector4 wywz(this Vector4 v) { return new Vector4(v.w, v.y, v.w, v.z); }
		public static Vector4 wyww(this Vector4 v) { return new Vector4(v.w, v.y, v.w, v.w); }
		public static Vector4 wzxx(this Vector4 v) { return new Vector4(v.w, v.z, v.x, v.x); }
		public static Vector4 wzxy(this Vector4 v) { return new Vector4(v.w, v.z, v.x, v.y); }
		public static Vector4 wzxz(this Vector4 v) { return new Vector4(v.w, v.z, v.x, v.z); }
		public static Vector4 wzxw(this Vector4 v) { return new Vector4(v.w, v.z, v.x, v.w); }
		public static Vector4 wzyx(this Vector4 v) { return new Vector4(v.w, v.z, v.y, v.x); }
		public static Vector4 wzyy(this Vector4 v) { return new Vector4(v.w, v.z, v.y, v.y); }
		public static Vector4 wzyz(this Vector4 v) { return new Vector4(v.w, v.z, v.y, v.z); }
		public static Vector4 wzyw(this Vector4 v) { return new Vector4(v.w, v.z, v.y, v.w); }
		public static Vector4 wzzx(this Vector4 v) { return new Vector4(v.w, v.z, v.z, v.x); }
		public static Vector4 wzzy(this Vector4 v) { return new Vector4(v.w, v.z, v.z, v.y); }
		public static Vector4 wzzz(this Vector4 v) { return new Vector4(v.w, v.z, v.z, v.z); }
		public static Vector4 wzzw(this Vector4 v) { return new Vector4(v.w, v.z, v.z, v.w); }
		public static Vector4 wzwx(this Vector4 v) { return new Vector4(v.w, v.z, v.w, v.x); }
		public static Vector4 wzwy(this Vector4 v) { return new Vector4(v.w, v.z, v.w, v.y); }
		public static Vector4 wzwz(this Vector4 v) { return new Vector4(v.w, v.z, v.w, v.z); }
		public static Vector4 wzww(this Vector4 v) { return new Vector4(v.w, v.z, v.w, v.w); }
		public static Vector4 wwxx(this Vector4 v) { return new Vector4(v.w, v.w, v.x, v.x); }
		public static Vector4 wwxy(this Vector4 v) { return new Vector4(v.w, v.w, v.x, v.y); }
		public static Vector4 wwxz(this Vector4 v) { return new Vector4(v.w, v.w, v.x, v.z); }
		public static Vector4 wwxw(this Vector4 v) { return new Vector4(v.w, v.w, v.x, v.w); }
		public static Vector4 wwyx(this Vector4 v) { return new Vector4(v.w, v.w, v.y, v.x); }
		public static Vector4 wwyy(this Vector4 v) { return new Vector4(v.w, v.w, v.y, v.y); }
		public static Vector4 wwyz(this Vector4 v) { return new Vector4(v.w, v.w, v.y, v.z); }
		public static Vector4 wwyw(this Vector4 v) { return new Vector4(v.w, v.w, v.y, v.w); }
		public static Vector4 wwzx(this Vector4 v) { return new Vector4(v.w, v.w, v.z, v.x); }
		public static Vector4 wwzy(this Vector4 v) { return new Vector4(v.w, v.w, v.z, v.y); }
		public static Vector4 wwzz(this Vector4 v) { return new Vector4(v.w, v.w, v.z, v.z); }
		public static Vector4 wwzw(this Vector4 v) { return new Vector4(v.w, v.w, v.z, v.w); }
		public static Vector4 wwwx(this Vector4 v) { return new Vector4(v.w, v.w, v.w, v.x); }
		public static Vector4 wwwy(this Vector4 v) { return new Vector4(v.w, v.w, v.w, v.y); }
		public static Vector4 wwwz(this Vector4 v) { return new Vector4(v.w, v.w, v.w, v.z); }
		public static Vector4 wwww(this Vector4 v) { return new Vector4(v.w, v.w, v.w, v.w); }
	}
}
