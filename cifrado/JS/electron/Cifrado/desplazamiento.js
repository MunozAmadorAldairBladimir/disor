var d= (function(){
let _desplazamiento = function(caracter,alfabeto,desplazamiento){
  desplazamiento=alfabeto.indexOf(caracter)+desplazamiento
  if(desplazamiento>alfabeto.length-1)
  {
    return alfabeto[desplazamiento-alfabeto.length]
  }else if(desplazamiento<0)
  {
      return alfabeto[desplazamiento+alfabeto.length]
  }
  return alfabeto[desplazamiento]
}

return {
  "desplazamiento": _desplazamiento
}
})();
