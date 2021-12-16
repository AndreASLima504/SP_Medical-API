import logo from '../../assets/logo_spmedgroup_v1.png';
import hamburger from '../../assets/iconeBurger.png'
import fundoLogin from '../../assets/smiling-touching-arms-crossed-room-hospital.jpg'
import './App.css';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <div class="containerHeader">
          <div class="divHamburger">
          <img src={hamburger} class = "hamburgerHeader"></img>
          </div>
          <div class="espaco">
          </div>
          <div class="divLogo">
          <img src={logo} alt = "logo" class = "Logo"></img>
          </div>
        </div>
      </header>
      
      <div class="filtro">
      <main class = "container">
        <section class="blocoLogin">
          <div class="blocoLoginContainer">
            <div class="formularioLogin">
              <span>FAÇA SEU LOGIN</span>
              <input type = "email" placeholder = "Email" class="email"></input>
              <input type = "password" placeholder = "Senha" class="senha"></input>
              <button class="botaoLogin">Login</button>
            </div>
            <div class="linksRelacionadosLogin">
              <a href="" class="esqueceuasenha">Esqueceu a senha?</a>
              <hr></hr>
              <a href="" class="naotemumaconta">Não tem uma conta?</a>
            </div>
          </div>
        </section>
      </main>
      </div>
    </div>
  );
}

export default App;
