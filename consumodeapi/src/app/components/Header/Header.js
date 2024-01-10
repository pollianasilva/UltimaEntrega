import React from 'react';
import Link from 'next/link';
import 'bootstrap/dist/css/bootstrap.min.css';
import styles from '@/app/components/Header/header.module.css';

export default function Header() {
  return (
    <header className={`${styles.background} ${styles.titulo}`}>
      <div className="container">
        <div className="d-flex justify-content-between align-items-center">
        <div style={{ display: 'flex', alignItems: 'center' }}>
  <img src="/icon.png" alt="logo" style={{ height: '50px' }} />
  <a href="http://localhost:3000" style={{ marginLeft: '10px', textDecoration: 'none', color: 'inherit' }}>
    BEIJA FLOR TURISMO
  </a>
</div>
          <nav>
            <ul className={styles.navList}>              
              <li>
                <Link href="/RotaUm">Ver cadastros</Link>
              </li>
              
            </ul>
          </nav>
        </div>
      </div>
    </header>
  );
}
