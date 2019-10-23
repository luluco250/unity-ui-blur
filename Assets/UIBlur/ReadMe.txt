## To use this shader:

1. Create a new material for your UI.

2. Assign the UI Blur material:
	- Use "UI/BlurFast" for most cases.
	- Use "UI/Blur" if you experience visual glitches.
		- There seems to be a bug with Unity's grab passes when using shared
		textures that can cause parts of the shader to fail when elements touch
		the viewport bounds.
		- Be aware this may cause a small performance drop, because Unity will
		then grab the background again for every UI element that uses the
		shader, rather than sharing the same grab between them.
		- The "fast" variant does **not** affect the blur quality, it merely
		makes a more optimized use of grab passes.

3. Change the material for your UI's graphic to the new material.

4. Adjust the blur size and opacity in the material as desired.
	- Note that the shader works with Unity's `Image` component and it's
	properties, so you can make use of sprites and colors.