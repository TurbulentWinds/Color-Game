using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour () {

  public int currentLevel = 0;
  
  public Dictionary<GameColor, GameObject> ColorToGO = new Dictionary<GameColor, GameObject>();
  
  public void LoadNextLevel () {
    currentLevel = currentLevel + 1;
    //get files in dir and find match to number, test if existing
    Texture2D image;
    if (image != null)
      LoadFromPNG(image); //pass in file
  }
  
  public void LoadFromPNG (Texture2D image) {
     for(int x = 0; x < image.width; x++) {
        for(int y = 0; y < image.height; y++) {
            Color co = image.GetPixel(x,y).Color;
            ColorToGO.Item[]
        }
     }
  } 
}
