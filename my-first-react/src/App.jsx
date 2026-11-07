import { useState } from 'react'
import './App.css'
import Login from './Login'
import Home from './Home'
import { Route, Routes, Navigate } from 'react-router-dom'

function App() {
  
  const[user, setUser] = useState(() => localStorage.getItem("user"))

  function login(email){
    localStorage.setItem("user", email)
    setUser(email)
  }

  function logout() {
    localStorage.removeItem("user")
    setUser(null)
  }

  return (
    <Routes>
      <Route
        path='/login' 
        element={user ? <Navigate to="/" replace /> : <Login onLogin={login} />}
      />
      <Route 
        path='/'
        element = { 
          user ? 
          (<Home user={user} onLogout={logout} />) 
          : 
          (<Navigate to="/login" replace />) }
      />
      <Route
        path='*' element={<Navigate to="/" replace />} 
      />
    </Routes>
  )
}

export default App
