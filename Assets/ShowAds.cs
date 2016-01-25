using UnityEngine;
using System.Collections;
using StartApp;
#if UNITY_ANDROID
public class VideoListenerImplementation : StartAppWrapper.VideoListener {
	public void onVideoCompleted() {
		// Grant user with the reward
	}
}
#endif
public class ShowAds : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Load the ad (after calling the init() function)
		#if UNITY_ANDROID
		StartAppWrapper.init();
		StartAppWrapper.loadAd();
		ShowSplash();
		#endif
	}

	//Adding the Splash Screen
	public void ShowSplash()
	{
		#if UNITY_ANDROID
		StartAppWrapper.showSplash();
		#endif
	}

	//show the ad
	public void ShowAd()
	{
		#if UNITY_ANDROID
		StartAppWrapper.showAd();
		StartAppWrapper.loadAd();
		#endif
	}

	//show banner 
	public void ShowBanner()
	{
		#if UNITY_ANDROID
		StartAppWrapper.addBanner( 
		                          StartAppWrapper.BannerType.AUTOMATIC,
		                          StartAppWrapper.BannerPosition.BOTTOM);
		#endif
	}

	//init video ad
	public void InitVideoAd()
	{
		#if UNITY_ANDROID
		VideoListenerImplementation videoListener = new VideoListenerImplementation ();
		StartAppWrapper.setVideoListener (videoListener);
		StartAppWrapper.loadAd(StartAppWrapper.AdMode.REWARDED_VIDEO);
		#endif
	}

	//show video ad
	public void ShowVideoAd()
	{
		#if UNITY_ANDROID
		StartAppWrapper.showAd();
		StartAppWrapper.loadAd(StartAppWrapper.AdMode.REWARDED_VIDEO);
		#endif
	}

}
