# Thanks for using my Pixel Art Skinning-Rigging System!

Creator: Mehmet Utku Özhun


# How To Use

 1. Create a Skin Texture with the editor of your choice.
 2. Create a Skeletal Texture with the editor of your choice.  Skeletal Texture means the RG values of each pixel corresponds to the coordinates of the color you want to use on the Skin Texture. 
 3. Import the asset package
 4. In your Unity Editor, either setup the URP or use the Built-In Pipeline
 5. In your editor, on the top menu, go to Tools/PASS/\<YourMaterialOfChoice>
 6. The material will be created in the Assets/PASS/Materials Folder.
 7. Click on your Material, in the Inspector window, choose the skin texture as your skin texture.
 8. If the Y values are counted from top to down on your image editor, set InverseY as 1, otherwise, set it as 0.
 9. If there is any height shift on your texture, set the HeightShift value to the shift amount.
 10.Drag and drop your material to your GameObject's Sprite Renderer's Material box.

## How to use the Sub Graph

If you are going to utilise several shaders, you will need to use the Sub Graph functionality. 

 1. In your Shader Graph, right click an empty space.
 2. Click "Create Node"
 3. In the list, choose "Sub Graphs/PixelArtSubGraph"
 4. The input values are the same as before,
 5. The output is the RGBA values of the finished product.

