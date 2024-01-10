import Footer from './components/Footer/Footer'
import Header from './components/Header/Header'
import './globals.css'

export default function RootLayout({ children }) {
  return (
    <html lang="pt-br">
      <body>
        <Header />
        <main>
        {children}
        </main>
        <Footer />
      </body>
    </html>
  )
}
