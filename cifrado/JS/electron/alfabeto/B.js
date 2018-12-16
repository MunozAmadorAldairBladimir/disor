var B = (function() {
function _claveAlfabeto(clave)
{
  return clave.concat(alfabeto.alfabeto()
              .filter(a=>!clave.includes(a)));
};


return {
  "claveAlfabeto": _claveAlfabeto
};
})();
