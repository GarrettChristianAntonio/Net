const bloque = document.querySelectorAll('.bloque')
const titular = document.querySelectorAll('.titular')

titular.forEach(cadaTitular, i)=> {
    titular[i].addEventListener('click', () => {
        bloque.forEach((cadaBloque, i) => {
            bloque[i].classList.remove('activo')
        })
        bloque[i].classList.add('activo')
    })
}