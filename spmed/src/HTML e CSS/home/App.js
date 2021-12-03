import logo from '../../assets/logo_spmedgroup_v1.png';
import hamburger from '../../assets/iconeBurger.png'
import fernandoStrada from '../../assets/smiling-touching-arms-crossed-room-hospital.png'
import './App.css';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={hamburger} class = "hamburgerHeader"></img>
        <img src={logo} alt = "logo" class = "Logo"></img>
      </header>
      <main>
        <section class="banner">
          <div>
            <h1>SP MEDICAL GROUP</h1>
            <h2>OS MELHORES planos de saúde da região, com centenas de médicos qualificados</h2>
          </div>
          <div>
            <span>Faça seu cadastro gratuito agora mesmo</span>
            <button class="botaoCadastrar"></button>
          </div>
        </section>
        <section class="Info">
          <h1>Por que nos procurar?</h1>
          <div>
            <p>Nós somos o SP Medical Group, uma empresa atuadora no ramo da saúde com raízes na região metropolitana de São Paulo, criada pelo médico Fernando Strada no ano de 2020, com o objetivo de trazer conforto e paz na busca pela saúde de quem você ama. Contamos com uma equipe de médicos que atuam em diversas áreas, para trazer um sorriso ao rosto de quem precisa.</p>
            <img src={fernandoStrada} class="fernandoMedico"></img>
          </div>
        </section>
        <section>
          
        </section>
      </main>
    </div>
  );
}

export default App;
