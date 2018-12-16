
var c = (function(){

var _cesar = function(desplazamiento,mensaje){
  return mensaje.split("")
                .map(a=>PD.parteDe(a,al.alfabeto(),desplazamiento)).join("");
}

return {
  "cesar": _cesar
}

})();
