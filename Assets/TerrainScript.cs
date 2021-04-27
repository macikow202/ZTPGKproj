using UnityEngine;
using System.Collections;
using System;

public class TerrainScript : MonoBehaviour
{
    [SerializeField]
    private Texture2D jpgImage;
    [SerializeField]
    private float setHeight;
    private Terrain _myTerr;
    private TerrainData _myTerrData;
    float[,] _terrHeights;

    void Start()
    {
        _myTerr = GetComponent<Terrain>();
        _myTerrData = _myTerr.terrainData;
        _myTerrData.heightmapResolution = jpgImage.width + 1;
        _myTerrData.size = new Vector3(jpgImage.width, setHeight, jpgImage.height);
        _terrHeights = _myTerrData.GetHeights(0, 0, _myTerrData.heightmapResolution, _myTerrData.heightmapResolution);
        Color[] pix = jpgImage.GetPixels();

        for (int z = 0; z < jpgImage.height; z++)
        {
            for (int x = 0; x < jpgImage.width; x++)
            {
                if (pix[x + z * jpgImage.height] != Color.white)
                {
                    _terrHeights[z, x] = 0.5f;
                }
                else
                {
                    _terrHeights[z, x] = 0;
                }
            }
        }

        _myTerrData.SetHeights(0, 0, _terrHeights);
    }

    void Update()
    {
    }

}