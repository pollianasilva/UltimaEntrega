import React from 'react';
import styles from '@/app/components/Footer/footer.module.css';
import 'bootstrap/dist/css/bootstrap.min.css';

export default function Footer() {
  return (
    <footer className={`${styles.background} ${styles.titulo}`}>
      <div className="container">
        <div className={styles.socialLinks}>
          <a href="https://www.tiktok.com/" target="_blank" rel="noopener noreferrer">
            <img src="/tiktok.png" width="50" height="50" alt="" />
          </a>
          <a href="https://www.instagram.com/" target="_blank" rel="noopener noreferrer">
            <img src="/insta.png" width="50" height="50" alt="" />
          </a>
          <a href="https://www.whatsapp.com/" target="_blank" rel="noopener noreferrer">
            <img src="/whats.png" width="50" height="50" alt="" />
          </a>
        </div>
        <p className="mb-0">
          <strong> &copy; Beija-Flor Turismo</strong> - Recode Pro, 2023
        </p>
        <p>
          Criada por{' '}
          <a href="https://www.linkedin.com/in/polliana-silva/" target="_blank" rel="noopener noreferrer">
            Polliana Silva
          </a>
        </p>
      </div>
    </footer>
  );
}
