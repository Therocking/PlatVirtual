{ pkgs, app, dockerTag }:

let

  mkImage = arch: pkgs.dockerTools.buildImage {
    name = "plataforma-virtual";
    tag = dockerTag;

    architecture = arch;

    copyToRoot = [
      app
      pkgs.cacert
    ];

    config = {
      Cmd = [ "${app}/bin/PlatVirtual" ];

      Env = [
        "ASPNETCORE_URLS=http://0.0.0.0:5000"
      ];

      ExposedPorts = {
        "5000/tcp" = {};
      };
    };
  };

  amd64 = mkImage "amd64";
  arm64 = mkImage "arm64";

  multiarch = pkgs.dockerTools.buildLayeredImage {
    name = "plataforma-virtual";
    tag = dockerTag;

    contents = [ app pkgs.cacert ];

    config = {
      Cmd = [ "${app}/bin/PlatVirtual" ];

      Env = [
        "ASPNETCORE_URLS=http://0.0.0.0:5000"
      ];
    };
  };

in
{
  inherit amd64 arm64 multiarch;
}
