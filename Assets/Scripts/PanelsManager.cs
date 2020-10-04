using UnityEngine;

public class PanelsManager : MonoBehaviour
{
    public GameObject PanelPrefab;
    public float PANEL_SIZE = 5.0f;
    public float GRID_EDGE_SIZE = 4.0f;

    Color getRGB(int r, int g, int b){
    	return new Color(r/225f,g/225f,b/225f);
    }
    void Start(){

	Color[] colourPalette = {
		getRGB(38,70,83),
		getRGB(42,157,143),
		getRGB(233,196,106),
		getRGB(244,162,97),
		getRGB(231,111,81)
	};
	for(float Y_coordinate= -1 * GRID_EDGE_SIZE / 2 * PANEL_SIZE ; Y_coordinate<= GRID_EDGE_SIZE/2 * PANEL_SIZE ; Y_coordinate+= PANEL_SIZE){
		for(float X_coordinate= -1 * GRID_EDGE_SIZE / 2 * PANEL_SIZE ; X_coordinate<= GRID_EDGE_SIZE/2 * PANEL_SIZE ; X_coordinate+= PANEL_SIZE){

		// Set panel color
		int randomColorIndex = Mathf.FloorToInt(Random.Range(0.0f, colourPalette.Length * 1.0f));
		Debug.Log(randomColorIndex);
		PanelPrefab.GetComponent<SpriteRenderer>().color = colourPalette[randomColorIndex]; 

		// Create panel
   		Instantiate(PanelPrefab, new Vector3(X_coordinate,Y_coordinate,0), Quaternion.identity); 
		}
	}
    }
}
