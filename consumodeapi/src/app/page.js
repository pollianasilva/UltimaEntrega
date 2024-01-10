import styles from './page.module.css'
import 'bootstrap/dist/css/bootstrap.min.css';



const Home = () => {


  return (
    <div className="container p-5">
      <h1 className={styles.alinhamento}>Conheça Nossos Destinos</h1>
      <div className={styles.separacao}></div>
      <div className={`row p-2 ${styles.cartoes}`}>
        {/* Card 1 */}
        <div className="col-md-3 col-6 p-2">
          <div className={`card h-100 ${styles.card}`}>
            <img
              className={`card-img-top ${styles['card-img-top']}`}
              src="/atena.jpg"
              alt="Imagem de capa do card"
            />
            <div className="card-body d-flex flex-column">
              <h5 className={`card-title text-center ${styles['custom-card-title']}`}>Atenas - Grécia</h5>
              <div className="card-footer">
              <a href="#" className={`btn btn-light btn-block mt-auto w-100 ${styles['custom-button']}`}>
                  Ver mais
                </a>
              </div>
            </div>
          </div>
        </div>

        {/* Card 2 */}
        <div className="col-md-3 col-6 p-2">
          <div className={`card h-100 ${styles.card}`}>
            <img
              className={`card-img-top ${styles['card-img-top']}`}
              src="/veni.jpg"
              alt="Imagem de capa do card"
            />
            <div className="card-body d-flex flex-column">
            <h5 className={`card-title text-center ${styles['custom-card-title']}`}>Veneza - Itália</h5>
              <div className="card-footer">
                <a href="#" className={`btn btn-light btn-block mt-auto w-100 ${styles['custom-button']}`}>
                  Ver mais
                </a>
              </div>
            </div>
          </div>
        </div>

        {/* Card 3 */}
        <div className="col-md-3 col-6 p-2">
          <div className={`card h-100 ${styles.card}`}>
            <img
              className={`card-img-top ${styles['card-img-top']}`}
              src="/eslo.jpg"
              alt="Imagem de capa do card"
            />
            <div className="card-body d-flex flex-column">
              <h5 className={`card-title text-center ${styles['custom-card-title']}`}>Bled - Eslovênia</h5>
              <div className="card-footer">
                <a href="#" className={`btn btn-light btn-block mt-auto w-100 ${styles['custom-button']}`}>
                  Ver mais
                </a>
              </div>
            </div>
          </div>
        </div>

        {/* Card 4 */}
        <div className="col-md-3 col-6 p-2">
          <div className={`card h-100 ${styles.card}`}>
            <img
              className={`card-img-top ${styles['card-img-top']}`}
              src="/jeru.jpg"
              alt="Imagem de capa do card"
            />
            <div className="card-body d-flex flex-column">
              <h5 className={`card-title text-center ${styles['custom-card-title']}`}>Israel - Jerusalém</h5>
              <div className="card-footer">
                <a href="#" className={`btn btn-light btn-block mt-auto w-100 ${styles['custom-button']}`}>
                  Ver mais
                </a>
              </div>
            </div>
          </div>
        </div>

        {/* Card 5 */}
        <div className="col-md-3 col-6 p-2">
          <div className={`card h-100 ${styles.card}`}>
            <img
              className={`card-img-top ${styles['card-img-top']}`}
              src="/pari.jpg"
              alt="Imagem de capa do card"
            />
            <div className="card-body d-flex flex-column">
              <h5 className={`card-title text-center ${styles['custom-card-title']}`}>Paris - França</h5>
              <div className="card-footer">
                <a href="#" className={`btn btn-light btn-block mt-auto w-100 ${styles['custom-button']}`}>
                  Ver mais
                </a>
              </div>
            </div>
          </div>
        </div>

        {/* Card 6 */}
        <div className="col-md-3 col-6 p-2">
          <div className={`card h-100 ${styles.card}`}>
            <img
              className={`card-img-top ${styles['card-img-top']}`}
              src="/mon.jpg"
              alt="Imagem de capa do card"
            />
            <div className="card-body d-flex flex-column">
              <h5 className={`card-title text-center ${styles['custom-card-title']}`}>Zermatt - Suiça</h5>
              <div className="card-footer">
                <a href="#" className={`btn btn-light btn-block mt-auto w-100 ${styles['custom-button']}`}>
                  Ver mais
                </a>
              </div>
            </div>
          </div>
        </div>

        {/* Card 7 */}
        <div className="col-md-3 col-6 p-2">
          <div className={`card h-100 ${styles.card}`}>
            <img
              className={`card-img-top ${styles['card-img-top']}`}
              src="/bigb.jpg"
              alt="Imagem de capa do card"
            />
            <div className="card-body d-flex flex-column">
              <h5 className={`card-title text-center ${styles['custom-card-title']}`}>Inglaterra - Reino Unido</h5>
              <div className="card-footer">
                <a href="#" className={`btn btn-light btn-block mt-auto w-100 ${styles['custom-button']}`}>
                  Ver mais
                </a>
              </div>
            </div>
          </div>
        </div>

        {/* Card 8 */}
        <div className="col-md-3 col-6 p-2">
          <div className={`card h-100 ${styles.card}`}>
            <img
              className={`card-img-top ${styles['card-img-top']}`}
              src="/China.jpg"
              alt="Imagem de capa do card"
            />
            <div className="card-body d-flex flex-column">
              <h5 className={`card-title text-center ${styles['custom-card-title']}`}>Ying - China</h5>
              <div className="card-footer">
                <a href="#" className={`btn btn-light btn-block mt-auto w-100 ${styles['custom-button']}`}>
                  Ver mais
                </a>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Home;
