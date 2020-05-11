function guardar_localStorage(usuario, password) {
   
    localStorage.clear();
    localStorage.setItem("usuario", usuario);
    localStorage.setItem("password", password);
}

function obtener_localStorage() {
   
   
  
  
    if (localStorage.getItem("usuario")) {
        let usuario = localStorage.getItem("usuario");
        let password = localStorage.getItem("password");

        $("#id_mail").val(usuario);
        $("#id_pass").val(password);
        console.log(usuario);
        console.log(password);
     
    }



}