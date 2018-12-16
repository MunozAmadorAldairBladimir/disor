var t = (function(){

var _transposicion = function(mensaje){
  return mensaje.split("").reverse().join("");
}

var _tia = function(agrupacion,mensaje){
  var a="",b="";
  for(let i=0;i<mensaje.length;i++){
    a+=mensaje[i];
    if(a.length % agrupacion==0){
      b+=_transposicion(a);
      a ="";
    }
  }
  return b+=a

}

return {
  "transposicion": _transposicion,
  "tia":  _tia
}

})();
