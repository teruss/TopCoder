UniGreed
=====

TopCoder plugin for Unity Editor.

Usage
-------------

1. Download the last updated version of TopCoder Greed plugin.
   * [Greed-2.0-RC](https://github.com/shivawu/topcoder-greed/releases/download/2.0-RC/Greed-2.0-RC-7.1.0.jar)

2. Set up Topcoder Greed plugin.
   1. Start TopCoder Arena and select Option/Editor.
   2. Click [Add] and enter the plugin information.
      * Name: Greed
      * EntryPoint: greed.Greed
      * ClassPath: /path/to/greed.jar
   3. Click [OK].
   4. Select Greed and click configure.
   5. Set the workspace path to the UniGreed directory in your Unity project.
      * Workspace: /path/to/YourUnityProject/Assets/UniGreed/Editor
   6. Click [Verify & Save].
  
3. Open a SRM problem in practice room to generate source code and unity scene.
   * UniGreed/SRM #/*.cs
   * UniGreed/SRM #/*Test.cs
   * UniGreed/SRM #/*.unity

4. Double click the *.unity file to open the scene in Unity Editor.

5. Press the Play button in the Unity Editor, and you can see the result of the test.

6. Modify the *.cs file to pass the test.

7. Click [Compile] in the TopCoder arena after passed all tests.

8. Click [Submit] to send your source code to TopCoder.

