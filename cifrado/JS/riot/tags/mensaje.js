riot.tag2('mensaje', '<fieldset> <legend>Cifrado cesar</legend> <label>Desplazamiento</label> <input name="desplaza" type="number"> <label>Mensaje cifrado</label> <textarea name="comment" ref="comentario" onkeyup="{cambioComentario}"></textarea> </fieldset> <article class="preview comment"> <p>{comment}</p> </article>', '', '', function(opts) {
  this.cambioComentario = function (evt) {
    let nueva_letra = String.fromCharCode(evt.charCode)
    this.comment = this.refs.comentario.value + nueva_letra
  }
});