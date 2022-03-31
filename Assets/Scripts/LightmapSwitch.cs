using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightmapSwitch : MonoBehaviour
{
    public Texture2D Angel_Lightmap0_light;
    public Texture2D Angel_Lightmap1_light;
    public Texture2D Angel_Lightmap2_light;
    public Texture2D Angel_Lightmap3_light;
    public Texture2D Angel_Lightmap4_light;
    public Texture2D Angel_Lightmap5_light;

    public Texture2D Angel_Lightmap0_dir;
    public Texture2D Angel_Lightmap1_dir;
    public Texture2D Angel_Lightmap2_dir;
    public Texture2D Angel_Lightmap3_dir;
    public Texture2D Angel_Lightmap4_dir;
    public Texture2D Angel_Lightmap5_dir;

    public Texture2D Devil_Lightmap0_light;
    public Texture2D Devil_Lightmap1_light;
    public Texture2D Devil_Lightmap2_light;
    public Texture2D Devil_Lightmap3_light;
    public Texture2D Devil_Lightmap4_light;
    public Texture2D Devil_Lightmap5_light;

    public Texture2D Devil_Lightmap0_dir;
    public Texture2D Devil_Lightmap1_dir;
    public Texture2D Devil_Lightmap2_dir;
    public Texture2D Devil_Lightmap3_dir;
    public Texture2D Devil_Lightmap4_dir;
    public Texture2D Devil_Lightmap5_dir;

    private LightmapData[] lightMaps1 = new LightmapData[1];
    private LightmapData[] lightMaps2 = new LightmapData[1];
    void Start()
    {
        lightMaps1[0] = new LightmapData();
        lightMaps1[0].lightmapDir = Angel_Lightmap0_light;
        lightMaps1[0].lightmapColor = Angel_Lightmap0_dir;
        lightMaps1[0].lightmapDir = Angel_Lightmap1_light;
        lightMaps1[0].lightmapColor = Angel_Lightmap1_dir;
        lightMaps1[0].lightmapDir = Angel_Lightmap2_light;
        lightMaps1[0].lightmapColor = Angel_Lightmap2_dir;
        lightMaps1[0].lightmapDir = Angel_Lightmap3_light;
        lightMaps1[0].lightmapColor = Angel_Lightmap3_dir;
        lightMaps1[0].lightmapDir = Angel_Lightmap4_light;
        lightMaps1[0].lightmapColor = Angel_Lightmap4_dir;
        lightMaps1[0].lightmapDir = Angel_Lightmap5_light;
        lightMaps1[0].lightmapColor = Angel_Lightmap5_dir;


        lightMaps2[0] = new LightmapData();
        lightMaps2[0].lightmapDir = Devil_Lightmap0_light;
        lightMaps2[0].lightmapColor = Devil_Lightmap0_dir;
        lightMaps2[0].lightmapDir = Devil_Lightmap1_light;
        lightMaps2[0].lightmapColor = Devil_Lightmap1_dir;
        lightMaps2[0].lightmapDir = Devil_Lightmap2_light;
        lightMaps2[0].lightmapColor = Devil_Lightmap2_dir;
        lightMaps2[0].lightmapDir = Devil_Lightmap3_light;
        lightMaps2[0].lightmapColor = Devil_Lightmap3_dir;
        lightMaps2[0].lightmapDir = Devil_Lightmap4_light;
        lightMaps2[0].lightmapColor = Devil_Lightmap4_dir;
        lightMaps2[0].lightmapDir = Devil_Lightmap5_light;
        lightMaps2[0].lightmapColor = Devil_Lightmap5_dir;

        LightmapSettings.lightmaps = lightMaps1;

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.B))
        {
            LightmapSettings.lightmaps = lightMaps2;
            Debug.Log("Switch!");
        }

    }
}
