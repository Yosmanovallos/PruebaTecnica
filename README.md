# Prueba Tecnica Aid for Aids

Haciendo uso de selenium o la herramienta de testing de su preferencia: 

- Abra google y realice la búsqueda de Aid for Aids.
- Obtenga todos los resultados de búsqueda mostrados y valide cuantos pertenecen al dominio [aidforaids.org](http://aidforaids.org/) (Puede enfocarse en los resultados de la primera página).
- Valide que el número de resultados de [aidforaids.org](http://aidforaids.org/) sea mayor a cero.
- Navegue a cada enlace perteneciente al dominio de [aidforaids.org](http://aidforaids.org/) encontrado y confirme que se muestre el título, ingrese a uno de los items del menú de navegación superior, confirme que cargan sin generar algún error.

## Requisitos

- Visual Studio version 2022
- C#
- SpecFlow ultima version.

## Instalación

0. Instala Specflow en Visual Studio
1. Clona el repositorio en tu máquina local.
2. Abre el proyecto en Visual Studio.
3. NuGet necesarios.
4. ![image](https://github.com/Yosmanovallos/PruebaTecnica/assets/119948396/6212de4e-6b0e-46d1-9594-d51571b79188)
5. ![image](https://github.com/Yosmanovallos/PruebaTecnica/assets/119948396/f18e5d62-12e9-4514-8f55-9d4c3437242b)
6. los otro NuGets faltantes los instala por defecto al instalar SpecFlow
7. Compila el proyecto para asegurarte de que no hay errores de compilación.

## Estructura del proyecto
el proyecto esta hecho en c#, con selenium y SpecFlow, este trabaja con gherkin y el patron de diseño POM
![image](https://github.com/Yosmanovallos/PruebaTecnica/assets/119948396/52ac510e-e8c2-46d5-83cb-d44d2a0c8acc)
En las clases .Feature se trabaja cada escenario en lenguaje gerkin 
en las pages se trabajaron todos los locators de las pruebas
y en los steps el paso a paso en codigo de los escnararios creados en c# con selenium

## Cómo utilizar
Ejecuta las pruebas automatizadas haciendo clic derecho en el archivo de prueba y seleccionando "Ejecutar pruebas" o presionando la combinación de teclas adecuada. 
Durante la ejecución de las pruebas, se mostrará información en la consola de salida de Visual Studio y se generará un informe de pruebas detallado. 
Verifica los resultados de las pruebas en la consola de salida o en el informe generado.

