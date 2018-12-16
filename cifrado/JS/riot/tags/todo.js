riot.tag2('todo', '<div each="{items}"> <h3>{title}</h3> <a onclick="{parent.remove}">Remove</a> </div>', '', '', function(opts) {

  this.items = [ { title: 'First' }, { title: 'Second' } ]

  this.remove = function(event) {

  }.bind(this)
});