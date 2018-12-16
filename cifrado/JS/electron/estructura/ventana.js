//var e = require("./elementos.js");
//const remote = require("electron").remote;
e.addToBody(e.creaDiv("mensaje"));
e.addToElement("mensaje",e.creaLabel("Mensaje"));
e.addToElement("mensaje",e.creaTextArea("mensajeTA",5,20));

e.addToBody(e.creaDiv("Fieldsets"));
e.addToElement("Fieldsets",e.creaFielset("Cesar","Cifrado César"));
e.addToElement("Cesar",e.creaDiv("desplazamiento"));
e.addToElement("Cesar",e.creaDiv("mensajeCifrado"));
e.addToElement("desplazamiento",e.creaLabel("Desplazamiento"));
e.addToElement("desplazamiento",e.creaInputText("desplazamientoIT"));
e.addToElement("mensajeCifrado",e.creaLabel("Mensaje Cifrado"));
e.addToElement("mensajeCifrado",e.creaTextArea("mensajeCifradoTA",5,20));

e.addToElement("Fieldsets",e.creaFielset("trasposicion","Cifrado por Transposición"));
e.addToElement("trasposicion",e.creaDiv("mensajeCifrado2"));
e.addToElement("mensajeCifrado2",e.creaLabel("Mensaje Cifrado"));
e.addToElement("mensajeCifrado2",e.creaTextArea("mensajeCifradoTA2",5,20));


e.addToElement("Fieldsets",e.creaFielset("Tia","Trasposicion inversa agrupada"));
e.addToElement("Tia",e.creaDiv("agrupacion"));
e.addToElement("Tia",e.creaDiv("mensajeCifrado3"));
e.addToElement("agrupacion",e.creaLabel("Agrupacion"));
e.addToElement("agrupacion",e.creaInputText("agrupacionIT"));
e.addToElement("mensajeCifrado3",e.creaLabel("Mensaje Cifrado"));
e.addToElement("mensajeCifrado3",e.creaTextArea("mensajeCifradoTA3",5,20));







/*let button = document.createElement("button");
button.textContent = "hola";
//document.body.appendChild(button);
e.addToBody(button);
e.addToBody(e.creaBoton("Boton","Cifrar"));
//e.addToElement("boton",e.creaBoton("Boton","Cifrar");
e.hola();*/
