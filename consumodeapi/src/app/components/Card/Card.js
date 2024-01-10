import { FaTimesCircle, FaHourglassHalf, FaCheckCircle } from 'react-icons/fa';
import styles from './card.module.css';

export default async function Card() {
  try {
    const cards = await fetch('http://localhost:5101/GetAllViagens').then(res => res.json());

    return (
      <div className={styles.container}>
        {cards?.map((card) => (
          <div key={card.id} className={styles.card}>
            <div className={styles.card_title}>
              <p>Dados da Viagem:</p>
              <p>{card.destino}</p>
              <div className={styles.status}>
                <span>Status: {renderStatusIcon(card.status)}</span>
              </div>
            </div>
          </div>
        ))}
      </div>
    );
  } catch (error) {
    console.error('Erro durante o fetch:', error);
  }
}

function renderStatusIcon(status) {
  switch (status) {
    case 1:
      return (
        <>
          <FaTimesCircle style={{ color: 'red' }} /> A fazer
        </>
      );
    case 2:
      return (
        <>
          <FaHourglassHalf style={{ color: 'yellow' }} /> Em andamento
        </>
      );
    case 3:
      return (
        <>
          <FaCheckCircle style={{ color: 'green' }} /> Concluído
        </>
      );
    default:
      return null;
  }
}
