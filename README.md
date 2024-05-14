# TP3-InfoPalooza
Materia: Taller de Programación 2. Escuela ORT sede Almagro        


Año: 4to Informática



TP 3 - POO + Static

Resolver el tp utilizando los conceptos vistos en clase sobre Clases y Objetos, integrando los conceptos sobre atributos y métodos estáticos.


Nos solicitan desarrollar el sistema para el InfoPalooza 2024. El mismo permitirá la inscripción de los clientes al evento, pudiendo participar en cualquiera de los 3 días. (También está la posibilidad de adquirir el combo “Full Pass”, que permite que los clientes puedan acceder a los 3 días.

No hay límite de inscripción de clientes para cada día.


Cada vez que un cliente se registra, recibe un ID único, que luego será guardado en su brazalete para acceder al evento.


Crear un Proyecto de consola dentro de la carpeta TP3, el cual debe contener:


La clase Cliente, que representa a cada uno de los clientes que participarán del evento.
Los objetos de esta clase se completan una vez que la persona elige su entrada y termina el registro.

Debe respetar el comportamiento de la siguiente clase descrita: (FechaInscripción es DateTime)






La clase estática Tiquetera, que debe respetar la siguiente estructura y comportamiento, definiendo los siguientes componentes estáticos:

                        


        

Descripción de Atributos y Métodos estáticos:

El atributo UltimoIDEntrada debe empezar en 0.
Será una variable que contiene siempre el último id utilizado para los tickets.
El atributo DicClientes debe tener como clave el Id de Entrada y como valor el Cliente que compra la entrada.
El método DevolverUltimoId devolverá el último id de entrada generado.
Debe solamente devolver la variable privada UltimoIDEntrada.
AgregarCliente: Recibe como parámetro toda la info de compra del cliente, lo ingresa al diccionario y devuelve el Id de Entrada generado.
BuscarCliente: recibe el Id de entrada y si lo encuentra devuelve toda la información del cliente que compró dicha entrada. En caso contrario devolver un objeto nulo o vacío.
CambiarEntrada: Recibe el Id de la entrada, el tipo de entrada por el cual quiere realizar el cambio y la cantidad. Debe permitir el cambio solo cuando el importe nuevo sea superior al importe anterior de la compra. Devuelve true o false si pudo o no realizar el cambio.
EstadisticasTicketera: Debe devolver una lista de tipo string con información definida más abajo en la definición del TP.
La clase Program, en la cual desarrollaremos el Main con lo siguiente:


Al ingresar al sistema, se debe un mostrar un menú con las siguientes opciones:
Nueva Inscripción
Obtener Estadísticas del Evento
Buscar Cliente
Cambiar entrada de un Cliente
Salir

Explicación de cada una de las opciones del Menú
Nueva Inscripción: 
Debe solicitar los datos del cliente y registrar su asistencia al evento, validando que haya ingresado correctamente DNI, apellido, nombre, tipo de entrada.

Debe guardar el importe abonado según la siguiente tabla de tipos de Entradas:

Opción 1 - Día 1 , valor a abonar $45000
Opción 2 - Día 2, valor a abonar $60000
Opción 3 - Día 3, valor a abonar $30000
Opción 4 - Full Pass, valor a abonar $100000
Obtener estadísticas del Evento.
Al presidente de la organización le interesa conocer en todo momento al seleccionar esta opción:
Cantidad de Clientes inscriptos
Cantidad de Clientes que compraron cada entrada.
Porcentaje de cantidad de entradas vendidas diferenciadas por tipo de entrada respecto al total de entradas compradas
Recaudación de cada tipo
Recaudación total.
                        Mostrar el mensaje “Aún no se anotó nadie” si el diccionario está vacío.

Buscar Cliente.
Al ingresar un ID, se debe poder visualizar toda la información de la inscripción de dicho Cliente al evento.
Cambiar entrada de un Cliente.
Ingresando el ID de un cliente que ya había reservado su lugar, un nuevo tipo de entrada, se puede modificar la entrada del cliente, actualizando en su correspondiente objeto, el tipo de entrada, total abonado y fecha. Solo en caso que el importe del nuevo tipo de entrada sea superior al que había comprado anteriormente.
Salir. Debe terminar el ciclo y finalizar el programa.


En este ejercicio se tomará en cuenta el funcionamiento del menú. La organización quiere que el sistema sea claro en cuanto a los mensajes que muestra hacia el usuario, pudiendo utilizar diferentes colores para mostrar diferentes tipos de información.



Formato de entrega

Subir al servicio del Campus Virtual el proyecto comprimido. El archivo a subir debe tener como nombre el apellido de los/las integrantes y el número de Trabajo Práctico, respetando la siguiente nomenclatura que muestra el ejemplo: TP03_Kristal_Medina.zip


No te olvides que estaremos siguiendo el progreso del trabajo práctico en GitHub! Esta herramienta debe ser incorporada desde el minuto 0 de empezar a trabajar en el proyecto. Al momento de subir el archivo al Campus, en la descripción de la entrega tendrás que pegar el enlace a tu repositorio de código!



