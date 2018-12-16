riot.tag2('cifrado-transposicion-inversa-agrupada', '<fieldset> <legend>Cifrado por transposición inversa agrupada</legend> <label>Agrupación</label> <input name="desplaza" type="number"> <label>Mensaje cifrado</label> <textarea name="comment" ref="comentario" onkeyup="{cambioComentario}"></textarea> </fieldset> <article class="preview comment"> <p>{comment}</p> </article>', '', '', function(opts) {
  this.cambioComentario = function (evt) {
    let nueva_letra = String.fromCharCode(evt.charCode)
    this.comment = this.refs.comentario.value + nueva_letra
  }
});