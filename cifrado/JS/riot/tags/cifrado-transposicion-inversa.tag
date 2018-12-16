<cifrado-transposicion-inversa>
 

  <fieldset>
  <legend>Cifrado por transposición inversa</legend>
    
    <label>Mensaje cifrado</label>
     <textarea name="comment" ref='comentario' onKeyUp={cambioComentario}></textarea>

<script>
  this.cambioComentario = function (evt) {
    let nueva_letra = String.fromCharCode(evt.charCode)
    this.comment = this.refs.comentario.value + nueva_letra
  }
</script>
    

  </fieldset>

  <article class='preview comment'>
    <p>{comment}</p>
  </article>
</cifrado-transposicion-inversa>