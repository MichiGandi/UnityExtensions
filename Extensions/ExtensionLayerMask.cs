//Extension for Unity Layer Mask
using UnityEngine;


namespace Extension.LayerMask
{
    public static class LayerMaskExtensions
    {
        /// <summary>
        /// Check if the gizen layer is enabled in the layermask.
        /// </summary>
        /// <param name="layer"></param>
        /// <returns>True, if the layer is enabled.</returns>
        public static bool Contains(this UnityEngine.LayerMask mask, int layer)
        {
            return (mask & (1 << layer)) > 0;
        }


        /// <summary>
        /// Creates a layermask, that matches the selected layer in the collision matrix.
        /// </summary>
        /// <param name="layer">The layer to read from the collision matrix.</param>
        /// <returns>The new created layer mask. </returns>
        public static UnityEngine.LayerMask GetLayerMaskFromCollisionMatrix(int layer)
        {
            UnityEngine.LayerMask layerMask = 0;

            for (int i = 0; i < 32; i++)
            {
                if (!Physics.GetIgnoreLayerCollision(layer, i))
                {
                    layerMask |= 1 << i;
                }
            }

            return layerMask;
		}


		/// <summary>
		/// Set a layermask, so that it matches the selected layer in the collision matrix.
		/// </summary>
		/// <param name="layer">The layer to read from the collision matrix.</param>
		/// <returns>The updated layermask itself.</returns>
		public static UnityEngine.LayerMask GetLayerMaskFromCollisionMatrix(this UnityEngine.LayerMask layerMask, int layer)
		{
            layerMask = GetLayerMaskFromCollisionMatrix(layer);
            return layerMask;
		}
	}
}