var e = (function() {

function _creaDiv(id){
  var newDiv = document.createElement("div");
  newDiv.setAttribute("id",id);
  return newDiv;
  //document.body.appendChild(newDiv);
}

function _creaInputText(id){
  var newInput = document.createElement("input");
  newInput.setAttribute("type", "number");
  newInput.setAttribute("id", id);
  return newInput;
}

function _creaLabel(id){
  var newLabel = document.createElement("label");
  newLabel.setAttribute("id", id);
  newLabel.innerHTML=id;
  return newLabel;
}

function _creaFielset(id,nombre){
  var newFieldset = document.createElement("FIELDSET");
  newFieldset.setAttribute("id",id)
  var newLegend = document.createElement("LEGEND");
  newLegend.innerHTML=nombre;
  newFieldset.appendChild(newLegend);
  return newFieldset;
}

function _creaTextArea(id,rows,cols){
  var newTextArea = document.createElement("textarea");
  newTextArea.setAttribute("id", id);
  newTextArea.setAttribute("rows", rows);
  newTextArea.setAttribute("cols", cols);
  return newTextArea;
}

function _creaBoton(id,valor){
  var newBoton = document.createElement("button");
  newBoton.setAttribute("id", id);
  newBoton.innerHTML=valor;
  return newBoton;
}

function _addToElement(idPadre,elemento){
  var padre = document.getElementById(idPadre);
  return padre.appendChild(elemento);
}
function _addToBody(elemento){
return document.body.appendChild(elemento);
}

function _hola(){
  let button = document.createElement("button");
  button.textContent = "hola2";
  document.body.appendChild(button);
}




return {
  "creaDiv" : _creaDiv,
  "creaInputText" : _creaInputText,
  "creaLabel" : _creaLabel,
  "creaTextArea" : _creaTextArea,
  "creaBoton" : _creaBoton,
  "addToElement" : _addToElement,
  "addToBody" : _addToBody,
  "hola" : _hola,
  "creaFielset":_creaFielset
};
})();
