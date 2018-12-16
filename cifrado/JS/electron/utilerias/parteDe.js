var PD = (function(){
let _parteDe = function (caracter,alfabeto,desplazamiento) {
  if(alfabeto.includes(caracter.toLowerCase())){
    return ma.mayuscula(caracter,al.alfabeto(),desplazamiento)
  }else{
  return caracter
}

}
return {
  "parteDe": _parteDe
}
})();
