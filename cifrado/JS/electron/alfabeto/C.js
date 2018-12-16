  var C = (function() {

function _alfabetOrdenado(clave,objeto){
Clave.limpiar(clave)
  .forEach(function(a){
    objeto[a] ? objeto[a]++ : objeto[a]=1;});
return B.claveAlfabeto(Object.keys(objeto));
};

return {
  "alfabetoOrdenado": _alfabetOrdenado
};
})();
