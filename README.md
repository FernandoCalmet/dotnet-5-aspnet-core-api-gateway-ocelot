# 馃 C# ASP.NET CORE 5 WEB API GATEWAY OCELOT

[![Github][github-shield]][github-url]
[![Kofi][kofi-shield]][kofi-url]
[![LinkedIn][linkedin-shield]][linkedin-url]
[![Khanakat][khanakat-shield]][khanakat-url]

## TABLA DE CONTENIDO

* [Acerca del proyecto](#acerca-del-proyecto)
* [Caracter铆sticas](#caracter铆sticas)
* [Instalaci贸n](#instalaci贸n)
* [Dependencias](#dependencias)
* [Licencia](#licencia)

## 馃敟 ACERCA DEL PROYECTO

Este proyecto es una muestra de una aplicaci贸n API Gateway con Ocelot. Se utilizo ``ASP.NET Core 5 Web API`` con C#.

## 鉁旓笍 CARACTER脥STICAS

- [x] JWT Authentication
- [x] Filter Header Customized
- [x] Blacklist Handler
- [x] Rate Limits Options (usefull for ddos prevention)
- [x] Security Settings by Users

## 鈿欙笍 INSTALACI脫N

Clonar el repositorio.

```bash
gh repo clone FernandoCalmet/dotnet-5-aspnet-core-api-gateway-ocelot
```

Ejecutar aplicaci贸n.

```bash
dotnet run
```

## 馃摜 DEPENDENCIAS

- [Ocelot](https://www.nuget.org/packages/Ocelot/) : Ocelot es una puerta de enlace API. El proyecto est谩 dirigido a personas que utilizan .NET y ejecutan una arquitectura orientada a servicios / microservicios que necesitan un punto de entrada unificado en su sistema. En particular, quiero una f谩cil integraci贸n con los tokens de portador y de referencia de IdentityServer. tokens de referencia. Ocelot es un grupo de middlewares en un orden espec铆fico. Ocelot manipula el objeto HttpRequest en un estado especificado por su configuraci贸n hasta que llega a un middleware de generador de solicitudes donde crea un objeto HttpRequestMessage que se utiliza para realizar una solicitud a un servicio posterior. El middleware que realiza la solicitud es lo 煤ltimo en la canalizaci贸n de Ocelot. No llama al siguiente middleware. La respuesta del servicio descendente se almacena en un repositorio con 谩mbito de solicitud y se recupera a medida que las solicitudes vuelven a subir por la canalizaci贸n de Ocelot. Hay una pieza de middleware que asigna HttpResponseMessage al objeto HttpResponse y que se devuelve al cliente. Eso es b谩sicamente todo con un mont贸n de otras caracter铆sticas.
- [Microsoft.AspNetCore.Authentication.JwtBearer](https://www.nuget.org/packages/Microsoft.AspNetCore.Authentication.JwtBearer/) : Middleware ASP.NET Core que permite que una aplicaci贸n reciba un token de portador de OpenID Connect.
- [Swashbuckle.AspNetCore](https://www.nuget.org/packages/Swashbuckle.AspNetCore/) : Herramientas Swagger para documentar API creadas en ASP.NET Core

## 馃搫 LICENCIA

Este proyecto est谩 bajo la Licencia (Licencia MIT) - mire el archivo [LICENSE](LICENSE) para m谩s detalles.

## 猸愶笍 DAME UNA ESTRELLA

Si esta Implementaci贸n le result贸 煤til o la utiliz贸 en sus Proyectos, d茅le una estrella. 隆Gracias! O, si te sientes realmente generoso, [隆Apoye el proyecto con una peque帽a contribuci贸n!](https://ko-fi.com/fernandocalmet).

<!--- reference style links --->
[github-shield]: https://img.shields.io/badge/-@fernandocalmet-%23181717?style=flat-square&logo=github
[github-url]: https://github.com/fernandocalmet
[kofi-shield]: https://img.shields.io/badge/-@fernandocalmet-%231DA1F2?style=flat-square&logo=kofi&logoColor=ff5f5f
[kofi-url]: https://ko-fi.com/fernandocalmet
[linkedin-shield]: https://img.shields.io/badge/-fernandocalmet-blue?style=flat-square&logo=Linkedin&logoColor=white&link=https://www.linkedin.com/in/fernandocalmet
[linkedin-url]: https://www.linkedin.com/in/fernandocalmet
[khanakat-shield]: https://img.shields.io/badge/khanakat.com-brightgreen?style=flat-square
[khanakat-url]: https://khanakat.com
