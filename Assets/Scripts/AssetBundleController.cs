using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;

namespace IzanamiWorkshop.Firebase.GameComponents
{
	public class AssetBundleController : MonoBehaviour
	{
		public static AssetBundleController Instance;

		[SerializeField] private bool clearCache;

        private void Awake()
        {
			Instance = this;
		}

        // Start is called before the first frame update
        void Start()
		{
			if (clearCache)
				Caching.ClearCache();
			LocalAsset();
		}

		private void LocalAsset()
		{
			var assetBundle = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "Bundles/prefabs"));
			if (assetBundle == null)
			{
				Debug.Log("Failed to load AssetBundle!");
				return;
			}

			GameObject go = assetBundle.LoadAsset<GameObject>("Sphere");
			Instantiate(go);

			//unload bundle if there is no more reference to be used from
			assetBundle.Unload(false);
		}
	}
}
