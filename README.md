# Unity Multi-Platform Deployment Test Project

This repository contains a minimal Unity project designed as a lightweight testbed for experimenting with multi-platform deployment workflows. The scene, titled `Main`, contains a simple rotating, reflective 3-sided prism. This minimal visual provides an easy-to-diagnose baseline for ensuring rendering, lighting, and animation are functioning correctly across platforms.

## 🎯 Purpose

The goal of this project is to:

- Validate Unity project deployment workflows across a broad range of platforms.
- Act as a baseline integration test for embedding Unity content (e.g., inside Flutter apps).
- Provide a trivially functional Unity app for build pipeline automation and troubleshooting.
- Help isolate platform-specific rendering, performance, or compatibility issues.

## 🔧 Features

- A single scene: `Main.unity`
- One 3-sided prism object:
  - Reflective material
  - Continuous rotation animation
  - Directional lighting
- Minimal dependencies
- No UI, input, audio, or external assets

## 🧪 Target Platforms

This project is intended to test and validate Unity deployment workflows on:

- ✅ Android
- ✅ iOS
- ✅ WebGL
- ✅ Windows
- ✅ macOS
- ✅ Linux
- ✅ PlayStation 4 / 5 (PS4/PS5)
- ✅ Universal Windows Platform (UWP)
- ✅ tvOS
- ✅ visionOS (Apple Vision Pro)

## 🚀 Usage

1. **Clone the repository**  
   ```bash
   git clone https://github.com/eoffermann/UnityBasicDemo.git
   cd UnityBasicDemo
   ```

2. **Open in Unity**  
   Use Unity Hub to open the project. It was built in Unity 6 (6000.0.32f1) but it should work in most modern Unity builds without issue.

3. **Switch Build Target**  
   Go to `File > Build Settings`, and select the platform you want to test. Click `Switch Platform`.

4. **Build and Run**  
   Use `Build` or `Build and Run` for deployment testing.

5. *(Optional)* Embed the Unity app in a parent project, such as a Flutter wrapper or native app container.

## 🧰 Notes

- No platform-specific code is included. The project should work *as-is* on all supported platforms.
- Useful for testing:
  - Build pipeline automation (CI/CD)
  - Unity + Native/Flutter integration
  - GPU compatibility (especially WebGL and mobile)
  - Input device pass-through if extended in the future

## 📜 License

MIT License. See [LICENSE](LICENSE) for details.

## 👤 Author

Created by Eddie Offermann & Big Blue Ceiling Prototyping and Fabrication, LCC. Contributions welcome.
