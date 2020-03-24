<div align="center">

<img src="https://raw.githubusercontent.com/unity-packages/installation/master/.github/logo.jpg" height="300px"></br>

[![npm](https://img.shields.io/badge/unity--packages-3.2.0-232c37.svg?style=for-the-badge)]()
[![license](https://img.shields.io/badge/license-Custom-%23ecc531.svg?style=for-the-badge)]()

[![npm](https://img.shields.io/badge/sponsor_the_project-donate-E12C9A.svg?style=for-the-badge)](https://paypal.me/jeffreylanters)

Inspector Buttons allow you to add a lot of power and flexibility to your workflow. Integrate your methods right into your editor with one simple attribute.

> When using this Unity Package, make sure to **Star** this repository. When using any of the packages please make sure to give credits to **Jeffrey Lanters** and **Unity Packages** somewhere in your app or game. **These packages are not allowed to be sold anywhere!**

**&Lt;**
**Made with &hearts; by Jeffrey Lanters**
**&Gt;**

<br/><br/>

</div>

# Installation

To install this package, add the following line to your `manifest.json` file located within your project's packages directory. For more details and troubleshooting of the Unity Packages manager, head over to the [Installation Guide](https://github.com/unity-packages/installation).

```json
"com.unity-packages.inspector-buttons": "git+https://github.com/unity-packages/inspector-buttons"
```

# USage

```cs
public class MyComponent : MonoBehaviour {
  [InspectorButton]
  private void Test () {
    Debug.Log ("Test");
  }
}
```
