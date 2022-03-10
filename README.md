# 🦄 C# ASP.NET CORE 5 WEB API GATEWAY OCELOT

[![Github][github-shield]][github-url]
[![Kofi][kofi-shield]][kofi-url]
[![LinkedIn][linkedin-shield]][linkedin-url]
[![Khanakat][khanakat-shield]][khanakat-url]

## TABLA DE CONTENIDO

* [Acerca del proyecto](#acerca-del-proyecto)
* [Características](#características)
* [Instalación](#instalación)
* [Dependencias](#dependencias)
* [Licencia](#licencia)

## 🔥 ACERCA DEL PROYECTO

Este proyecto es una muestra de una aplicación API Gateway con Ocelot. Se utilizo ``ASP.NET Core 5 Web API`` con C#.

## ✔️ CARACTERÍSTICAS

- [x] JWT Authentication
- [x] Filter Header Customized
- [x] Blacklist Handler
- [x] Rate Limits Options (usefull for ddos prevention)
- [x] Security Settings by Users

## ⚙️ INSTALACIÓN

Clonar el repositorio.

```bash
gh repo clone FernandoCalmet/DOTNET-5-ASPNET-Core-API-Gateway-Ocelot
```

Ejecutar aplicación.

```bash
dotnet run
```

## 📥 DEPENDENCIAS

- [Ocelot](https://www.nuget.org/packages/Ocelot/) : Ocelot es una puerta de enlace API. El proyecto está dirigido a personas que utilizan .NET y ejecutan una arquitectura orientada a servicios / microservicios que necesitan un punto de entrada unificado en su sistema. En particular, quiero una fácil integración con los tokens de portador y de referencia de IdentityServer. tokens de referencia. Ocelot es un grupo de middlewares en un orden específico. Ocelot manipula el objeto HttpRequest en un estado especificado por su configuración hasta que llega a un middleware de generador de solicitudes donde crea un objeto HttpRequestMessage que se utiliza para realizar una solicitud a un servicio posterior. El middleware que realiza la solicitud es lo último en la canalización de Ocelot. No llama al siguiente middleware. La respuesta del servicio descendente se almacena en un repositorio con ámbito de solicitud y se recupera a medida que las solicitudes vuelven a subir por la canalización de Ocelot. Hay una pieza de middleware que asigna HttpResponseMessage al objeto HttpResponse y que se devuelve al cliente. Eso es básicamente todo con un montón de otras características.
- [Microsoft.AspNetCore.Authentication.JwtBearer](https://www.nuget.org/packages/Microsoft.AspNetCore.Authentication.JwtBearer/) : Middleware ASP.NET Core que permite que una aplicación reciba un token de portador de OpenID Connect.
- [Swashbuckle.AspNetCore](https://www.nuget.org/packages/Swashbuckle.AspNetCore/) : Herramientas Swagger para documentar API creadas en ASP.NET Core

## 📄 LICENCIA

Este proyecto está bajo la Licencia (Licencia MIT) - mire el archivo [LICENSE](LICENSE) para más detalles.

## ⭐️ DAME UNA ESTRELLA

Si esta Implementación le resultó útil o la utilizó en sus Proyectos, déle una estrella. ¡Gracias! O, si te sientes realmente generoso, [¡Apoye el proyecto con una pequeña contribución!](https://ko-fi.com/fernandocalmet).

<!--- reference style links --->
[github-shield]: https://img.shields.io/badge/-@fernandocalmet-%23181717?style=flat-square&logo=github
[github-url]: https://github.com/fernandocalmet
[kofi-shield]: https://img.shields.io/badge/-@fernandocalmet-%231DA1F2?style=flat-square&logo=kofi&logoColor=ff5f5f
[kofi-url]: https://ko-fi.com/fernandocalmet
[linkedin-shield]: https://img.shields.io/badge/-fernandocalmet-blue?style=flat-square&logo=Linkedin&logoColor=white&link=https://www.linkedin.com/in/fernandocalmet
[linkedin-url]: https://www.linkedin.com/in/fernandocalmet
[khanakat-shield]: https://img.shields.io/badge/khanakat.com-brightgreen?style=flat-square
[khanakat-url]: https://khanakat.com