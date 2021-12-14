import logo from '../../assets/logo_spmedgroup_v1.png';
import hamburger from '../../assets/iconeBurger.png'
import fundoLogin from '../../assets/smiling-touching-arms-crossed-room-hospital.jpg'
import './App.css';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={hamburger} class = "hamburgerHeader"></img>
        <img src={logo} alt = "logo" class = "Logo"></img>
      </header>
      <main class = "container">
        <section class="blocoLogin">
          <div class="blocoLoginContainer">
            <div class="formularioLogin">
              <span>FAÇA SEU LOGIN</span>
            <input type = "email" placeholder = "Email" class="email"></input>
              <input type = "password" placeholder = "Senha" class="senha"></input>
              <button class="botaoLogin">Login</button>
            </div>
            <div>
              <a href="">Esqueceu a senha?</a>
              <hr></hr>
              <a href="">Não tem uma conta?</a>
            </div>
          </div>
        </section>
      </main>
    </div>
  );
}

export default App;
