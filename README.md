# Photon: lobby

Isso é de out/2023, da época da faculdade. Coloquei no GitHub em 2026 como registro e deixei como estava.

Meu primeiro teste de multiplayer com Photon PUN 2, poucas semanas antes do Magic Wars. Ele conecta no servidor, pede um apelido e deixa criar ou entrar numa sala de até 4 jogadores, mostrando o erro quando algo falha. A lógica está no `NetWorkController.cs` e no `Lobby.cs`.

Tirei o App ID do Photon antes de subir. Pra rodar, crie um App ID grátis no painel da Photon e coloque em `Assets/Photon/PhotonUnityNetworking/Resources/PhotonServerSettings.asset`.

## Como abrir

Na época só exportei a pasta Assets num `.unitypackage`, então não tem ProjectSettings. Crie um projeto 2D vazio no Unity (nessa época eu usava a 2021.3) e importe `pacote-original/PhotonDimas.unitypackage` em Assets > Import Package > Custom Package.

## Créditos

Photon PUN 2, Joystick Pack e Free Pixel Space Platform Pack (Asset Store).

Outros projetos da faculdade: [projetos-da-faculdade](https://github.com/gustadimas/projetos-da-faculdade)
