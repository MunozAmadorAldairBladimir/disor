var ma = (function(){
let _mayuscula = function (caracter,alfabeto,desplazamiento) {
  if(caracter==caracter.toUpperCase()){
    return d.desplazamiento(caracter.toLowerCase(),al.alfabeto(),desplazamiento).toUpperCase();
  }else{
  return d.desplazamiento(caracter,al.alfabeto(),desplazamiento);}

}
return {
  "mayuscula":_mayuscula
}
})();
