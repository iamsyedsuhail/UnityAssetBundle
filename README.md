# UnityBatchAssetBundle

This repo will help you create asset bundles, based on project structure.

## Scenario
We want to create multiple asset bundle, but without tagging them specifically, but use project structure, to define the bundles appropriately.

## We will be focusing on,
- Maintaining a structure to fetch assets for asset bundles.
- Create asset bundles using editor script.
- Load asset bundles from streaming assets.

## Prerequisite
- Unity Engine 2021.3.0f1, you can download it from [here](https://unity3d.com/get-unity/download).

## Scripts and their uses.
- ```Assets/Scripts/Editor/AssetBundleCreator.cs``` is used to create asset bundle
- ```Assets/Scripts/AssetBundleController.cs``` is used to load assets bundle from ```StreamingAssets/Bundles```.

## Project Structure.
- We will load assets from ```Assets/LocalAssets``` path, the sub folder defined inside wil act as individual asset bundles, any content within these
subfolder will be part of the respective assetbundle.

## More
- This project loads bundle from ```StreamingAssets/Bundles```, if you want to learn how we can fetch from Firebase(or get idea about CDN), check my
[UnityFirebaseDemo](https://github.com/iamsyedsuhail/UnityFirebaseDemo) Repo.


