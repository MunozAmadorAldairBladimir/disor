var Clave = (function() {

function _limpiar(clave){
return clave.toUpperCase().split("")
.filter(a=>alfabeto.alfabeto().includes(a));

};

return {
"limpiar": _limpiar
};
})();
