# Elements.Style (WIP)

Aims to be, shared code style/project configuration for Yellow Dog Man Studios(YDMS) Projects.

As YDMS increases the amount of Open Source Software it produces, the question of Code Style continues to emerge. This repo will be an answer to that question.

## Goals
- Sharable & Synced Code Style rules for YDMS .NET Projects
- Discussion/Issue Hub for YDMS Code Style
- Low Effort - Each project should be able to include this easily
- Synchronized - We don't need to manually copy files around
- Versioned - new warnings/code style items do not suddenly appear

## Setup

To use Elements.Style in your project:

1. Add it as a PackageReference to your project:

```
<PackageReference Include="YellowDogMan.Elements.Style" Version="0.1.0" />
```

2. Create or edit a `Directory.build.props` file in the root of your Repository, Inside ensure the RepositoryRoot property is specified:
```
<Project>
  <PropertyGroup>
    <RepositoryRoot><Repository Root></RepositoryRoot>
  </PropertyGroup>
</Project>
```

And populated with your Repository root. Common values for this can be found:
- By using `<SolutionDir>` as in: `<RepositoryRoot>$(SolutionDir)</RepositoryRoot>`
- By using `$(MSBuildThisFileDirectory)` as in: `<RepositoryRoot>$(MSBuildThisFileDirectory)</RepositoryRoot>`

We've made some automation to try and do this for you, but it might not work correctly. See https://github.com/Yellow-Dog-Man/Elements.Style/issues/4 for more information

3. Build your project, it'll copy relevant files to their correct location.


### Commit Changes

As this project, copies build and style files to their appropriate location within your project. It is important to commit the changes if they change.

This ensures that, web based tools such as GitHub also have the latest files.

## Versioning

As Elements.Style is a regular NuGet Package, we use its versions to roll out new or enhanced code style changes to new projects. Using versioning also ensures that you only need to apply new styles when you're ready, stay on an older version and you'll skip the new rules.

Eventually, we'll instruct Dependabot to start automatically bumping this Package across our repositories though.

## Components

### NuGet

This project produces a NuGet package called/ with an id of: `YellowDogMan.Elements.Style`. 

### .editorconfig

A shared collection of rules and settings for various file types. Full documentation is available on [the editor config website](http://EditorConfig.org)

Uses [RehanSaeed's Editor Config](https://github.com/RehanSaeed/EditorConfig) as a base.

### Style & Config Synchronization

By packing a .props and .targets file in `buildTransitive` folder, that have the same name as the package name, we get some cool properties:
1. The .targets within the Targets file will run
2. The .props within the Props file will be included.

These items when combined, allow us to place style rules etc within your project.


## Testing Locally

Elements.Style.Test exists purely as a test project to test Elements.Style. To test new versions locally:
1. cd into `Elements.Style`
2. `dotnet pack -c Release -p:Version=0.0.1-local.<x>` where `x` is a version number
3. Update the `<PackageReference>` in `Elements.Style.Test.csproj` with the new number.

## References & Resources

### MSBuild
- [DotMorten's MSBuild CheatSheet](https://gist.github.com/dotMorten/7db5cc3ae4ab72db784df0793b45d6ac)

### Packing and Distribution of .NET Props and Code Style
- [Kwality.CodeStyle](https://github.com/dotnet-essentials/Kwality.CodeStyle)
- [SimonCropp/ProjectDefaults](https://github.com/SimonCropp/ProjectDefaults)