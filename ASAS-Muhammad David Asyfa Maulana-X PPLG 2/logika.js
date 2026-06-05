/* ========== HELPER & UTILITAS (LOCAL STORAGE & TOAST) ========== */
// DATA HOTEL
const hotels = [
    { id: 1, nama: 'Hotel Malioboro Inn', harga: 450000, lokasi: 'Jl. Malioboro, Yogyakarta', bintang: 3, mapBbox: '110.359%2C-7.795%2C110.371%2C-7.782', mapMarker: '7.7889/110.365' },
    { id: 2, nama: 'Grand Borobudur Hotel', harga: 850000, lokasi: 'Jl. Magelang, Borobudur', bintang: 4, mapBbox: '110.19%2C-7.625%2C110.22%2C-7.595', mapMarker: '7.6079/110.204' },
    { id: 3, nama: 'Prambanan Heritage Resort', harga: 1250000, lokasi: 'Jl. Prambanan, Sleman', bintang: 5, mapBbox: '110.48%2C-7.765%2C110.51%2C-7.745', mapMarker: '7.752/110.493' },
    { id: 4, nama: 'Parangtritis Beach Hotel', harga: 375000, lokasi: 'Jl. Parangtritis, Bantul', bintang: 2, mapBbox: '110.32%2C-8.025%2C110.35%2C-8.005', mapMarker: '8.015/110.335' },
    { id: 5, nama: 'Keraton Royal Residence', harga: 2100000, lokasi: 'Jl. Rotowijayan, Yogyakarta', bintang: 5, mapBbox: '110.36%2C-7.81%2C110.375%2C-7.798', mapMarker: '7.805/110.367' }
];

function getUsers() {
    return JSON.parse(localStorage.getItem('hotel_users') || '[]');
}
function saveUsers(users) {
    localStorage.setItem('hotel_users', JSON.stringify(users));
}
function getBookings() {
    return JSON.parse(localStorage.getItem('hotel_bookings') || '[]');
}
function saveBookings(bookings) {
    localStorage.setItem('hotel_bookings', JSON.stringify(bookings));
}
function getCurrentUser() {
    return JSON.parse(sessionStorage.getItem('hotel_current_user') || 'null');
}
function setCurrentUser(user) {
    sessionStorage.setItem('hotel_current_user', JSON.stringify(user));
}
function clearCurrentUser() {
    sessionStorage.removeItem('hotel_current_user');
}

function showToast(message, type) {
    const container = document.getElementById('toastContainer');
    const toast = document.createElement('div');
    toast.className = `toast ${type}`;
    const iconMap = { success: 'fa-check-circle', error: 'fa-exclamation-circle' };
    toast.innerHTML = `<i class="fas ${iconMap[type] || 'fa-info-circle'}"></i><span>${message}</span>`;
    container.appendChild(toast);

    setTimeout(() => {
        toast.style.animation = 'toastOut 0.4s ease forwards';
        setTimeout(() => toast.remove(), 400);
    }, 3500);
}


/* ========================================
   1. NAVBAR
   ======================================== */
const protectedPages = ['pemesanan'];

function navigateTo(page) {
    // Cek proteksi halaman
    const user = getCurrentUser();
    if (protectedPages.includes(page) && !user) {
        showToast('Silakan login terlebih dahulu', 'error');
        page = 'login';
    }

    // Sembunyikan semua halaman
    document.querySelectorAll('.page').forEach(p => p.classList.remove('active'));
    const target = document.getElementById('page-' + page);
    if (target) target.classList.add('active');

    // Update navbar active state
    document.querySelectorAll('.nav-links li a[data-page]').forEach(a => {
        a.classList.toggle('active', a.dataset.page === page);
    });

    // Tutup menu mobile
    document.getElementById('navLinks').classList.remove('open');
    document.getElementById('hamburgerIcon').className = 'fas fa-bars';

    // Isi nama di form pemesanan jika sudah login
    if (page === 'pemesanan' && user) {
        document.getElementById('nama').value = user.name || '';
        document.getElementById('nama').classList.add('has-value');
    }

    window.scrollTo({ top: 0, behavior: 'smooth' });
}

function toggleMenu() {
    const links = document.getElementById('navLinks');
    const icon = document.getElementById('hamburgerIcon');
    links.classList.toggle('open');
    icon.className = links.classList.contains('open') ? 'fas fa-times' : 'fas fa-bars';
}

function updateNavAuth() {
    const navAuth = document.getElementById('navAuth');
    const user = getCurrentUser();

    if (user) {
        navAuth.innerHTML = `
            <div class="nav-user-info">
                <div class="user-avatar">${user.name.charAt(0).toUpperCase()}</div>
                <span>${user.name}</span>
                <button class="nav-logout" onclick="handleLogout()">
                    <i class="fas fa-sign-out-alt"></i> Keluar
                </button>
            </div>
        `;
    } else {
        navAuth.innerHTML = `
            <a class="nav-auth-btn" onclick="navigateTo('login')">
                <i class="fas fa-user"></i> Masuk
            </a>
        `;
    }
}


/* ========================================
   2. HOME
   ======================================== */
function initParallaxHero() {
    const heroEl = document.querySelector('.home-hero');
    if (heroEl) {
        window.addEventListener('mousemove', (e) => {
            const cx = window.innerWidth / 2;
            const cy = window.innerHeight / 2;
            const dx = (e.clientX - cx) / cx;
            const dy = (e.clientY - cy) / cy;
            document.querySelectorAll('.particle').forEach((p, i) => {
                const factor = (i + 1) * 8;
                p.style.transform = `translate(${dx * factor}px, ${dy * factor}px)`;
            });
        });
    }
}


/* ========================================
   3. FORM LOGIN
   ======================================== */
function switchAuth(mode) {
    const loginForm = document.getElementById('loginForm');
    const registerForm = document.getElementById('registerForm');
    const title = document.getElementById('authTitle');
    const subtitle = document.getElementById('authSubtitle');

    // Clear errors
    document.querySelectorAll('.auth-error').forEach(e => e.classList.remove('visible'));
    document.querySelectorAll('.input-group input').forEach(i => i.classList.remove('input-error'));

    if (mode === 'register') {
        loginForm.classList.remove('active');
        registerForm.classList.add('active');
        title.textContent = 'Daftar';
        subtitle.textContent = 'Buat akun baru untuk mulai memesan';
    } else {
        registerForm.classList.remove('active');
        loginForm.classList.add('active');
        title.textContent = 'Masuk';
        subtitle.textContent = 'Gunakan akun Anda untuk melanjutkan';
    }
}

function togglePw(inputId, btn) {
    const input = document.getElementById(inputId);
    const icon = btn.querySelector('i');
    const isPassword = input.type === 'password';
    input.type = isPassword ? 'text' : 'password';
    icon.className = isPassword ? 'fas fa-eye-slash' : 'fas fa-eye';
}

function handleLogin(e) {
    e.preventDefault();

    const email = document.getElementById('loginEmail').value.trim();
    const password = document.getElementById('loginPassword').value;
    const errorEl = document.getElementById('loginError');
    const btn = e.target.querySelector('.btn-auth');

    // Clear error
    errorEl.classList.remove('visible');
    document.querySelectorAll('#loginForm .input-group input').forEach(i => i.classList.remove('input-error'));

    // Validasi
    if (!email || !password) {
        errorEl.innerHTML = '<i class="fas fa-exclamation-circle"></i> Semua field wajib diisi';
        errorEl.classList.add('visible');
        if (!email) document.getElementById('loginEmail').classList.add('input-error');
        if (!password) document.getElementById('loginPassword').classList.add('input-error');
        return false;
    }

    // Loading
    btn.classList.add('loading');
    btn.disabled = true;

    setTimeout(() => {
        btn.classList.remove('loading');
        btn.disabled = false;

        const users = getUsers();
        const user = users.find(u => u.email === email && u.password === password);

        if (!user) {
            errorEl.innerHTML = '<i class="fas fa-exclamation-circle"></i> Email atau kata sandi salah';
            errorEl.classList.add('visible');
            return;
        }

        // Login berhasil
        setCurrentUser(user);
        updateNavAuth();
        showToast(`Selamat datang, ${user.name}!`, 'success');
        navigateTo('home');
    }, 1000);

    return false;
}


/* ========================================
   4. FORM REGISTER
   ======================================== */
function handleRegister(e) {
    e.preventDefault();

    const name = document.getElementById('regName').value.trim();
    const email = document.getElementById('regEmail').value.trim();
    const password = document.getElementById('regPassword').value;
    const confirm = document.getElementById('regConfirm').value;
    const errorEl = document.getElementById('registerError');
    const btn = e.target.querySelector('.btn-auth');

    errorEl.classList.remove('visible');
    document.querySelectorAll('#registerForm .input-group input').forEach(i => i.classList.remove('input-error'));

    // Validasi
    let errors = [];
    if (!name) { errors.push('Nama wajib diisi'); document.getElementById('regName').classList.add('input-error'); }
    if (!email) { errors.push('Email wajib diisi'); document.getElementById('regEmail').classList.add('input-error'); }
    if (!password) { errors.push('Kata sandi wajib diisi'); document.getElementById('regPassword').classList.add('input-error'); }
    if (password && password.length < 6) { errors.push('Kata sandi minimal 6 karakter'); document.getElementById('regPassword').classList.add('input-error'); }
    if (password !== confirm) { errors.push('Konfirmasi kata sandi tidak cocok'); document.getElementById('regConfirm').classList.add('input-error'); }

    if (errors.length > 0) {
        errorEl.innerHTML = `<i class="fas fa-exclamation-circle"></i> ${errors[0]}`;
        errorEl.classList.add('visible');
        return false;
    }

    // Cek duplikat email
    const users = getUsers();
    if (users.find(u => u.email === email)) {
        errorEl.innerHTML = '<i class="fas fa-exclamation-circle"></i> Email sudah terdaftar. Silakan login.';
        errorEl.classList.add('visible');
        document.getElementById('regEmail').classList.add('input-error');
        return false;
    }

    btn.classList.add('loading');
    btn.disabled = true;

    setTimeout(() => {
        btn.classList.remove('loading');
        btn.disabled = false;

        // Simpan user baru
        const newUser = { name, email, password };
        users.push(newUser);
        saveUsers(users);

        // Auto login
        setCurrentUser(newUser);
        updateNavAuth();
        showToast('Pendaftaran berhasil! Selamat datang.', 'success');
        navigateTo('home');
    }, 1200);

    return false;
}

function handleLogout() {
    clearCurrentUser();
    updateNavAuth();
    showToast('Anda telah keluar', 'success');
    navigateTo('home');
}


/* ========================================
   5. PEMESANAN
   ======================================== */
function initHotelDropdown() {
    const hotelSelect = document.getElementById('hotel');
    hotels.forEach(h => {
        const opt = document.createElement('option');
        opt.value = h.id;
        opt.textContent = h.nama;
        hotelSelect.appendChild(opt);
    });
}

function onHotelChange() {
    const hotelSelect = document.getElementById('hotel');
    const id = parseInt(hotelSelect.value);
    const info = document.getElementById('hotelInfo');
    const mapFrame = document.getElementById('mapFrame');
    const mapOverlay = document.getElementById('mapOverlay');

    if (!id) {
        info.classList.remove('visible');
        mapOverlay.innerHTML = '<i class="fas fa-info-circle"></i> Pilih hotel untuk melihat lokasi';
        return;
    }

    const hotel = hotels.find(h => h.id === id);
    if (!hotel) return;

    const bintangStr = '<i class="fas fa-star" style="color:var(--accent);font-size:11px;"></i>'.repeat(hotel.bintang);
    info.innerHTML = `<strong>${hotel.nama}</strong> ${bintangStr}<br><i class="fas fa-map-pin" style="color:var(--accent);margin-right:4px;"></i>
    ${hotel.lokasi}<br><i class="fas fa-tag" style="color:var(--accent);margin-right:4px;"></i>Rp ${hotel.harga.toLocaleString('id-ID')} / malam`;
    info.classList.add('visible');

    mapFrame.src = `https://www.openstreetmap.org/export/embed.html?bbox=${hotel.mapBbox}&layer=mapnik&marker=${hotel.mapMarker}`;
    mapOverlay.innerHTML = `<i class="fas fa-map-marker-alt" style="color:var(--accent);"></i> ${hotel.nama}`;
}

function hitungTotal() {
    const hotelSelect = document.getElementById('hotel');
    const hotelId = parseInt(hotelSelect.value);
    const kamar = parseInt(document.getElementById('kamar').value) || 0;
    const malam = parseInt(document.getElementById('malam').value) || 0;

    if (!hotelId) { showToast('Pilih hotel terlebih dahulu', 'error'); return; }
    if (kamar < 1 || malam < 1) { showToast('Jumlah kamar dan lama menginap minimal 1', 'error'); return; }

    const hotel = hotels.find(h => h.id === hotelId);
    const total = hotel.harga * kamar * malam;
    animateTotal(total);
}

function animateTotal(target) {
    const el = document.getElementById('totalHarga');
    const start = parseInt(el.dataset.current || '0');
    const duration = 600;
    const startTime = performance.now();

    function step(now) {
        const elapsed = now - startTime;
        const progress = Math.min(elapsed / duration, 1);
        const ease = 1 - Math.pow(1 - progress, 3);
        const current = Math.round(start + (target - start) * ease);
        el.textContent = 'Rp ' + current.toLocaleString('id-ID');
        if (progress < 1) {
            requestAnimationFrame(step);
        } else {
            el.dataset.current = target;
        }
    }
    requestAnimationFrame(step);
}

let pendingOrder = {};

function pesanHotel() {
    clearErrors();

    const user = getCurrentUser();
    if (!user) { showToast('Silakan login terlebih dahulu', 'error'); navigateTo('login'); return; }

    const nama = document.getElementById('nama').value.trim();
    const hotelSelect = document.getElementById('hotel');
    const hotelId = parseInt(hotelSelect.value);
    const kamar = parseInt(document.getElementById('kamar').value) || 0;
    const malam = parseInt(document.getElementById('malam').value) || 0;
    const pembayaran = document.getElementById('pembayaran').value;

    let hasError = false;
    if (!nama) { showFieldError('nama', 'namaError'); hasError = true; }
    if (!hotelId) { showFieldError('hotel', 'hotelError'); hasError = true; }
    if (kamar < 1) { showFieldError('kamar', 'kamarError'); hasError = true; }
    if (malam < 1) { showFieldError('malam', 'malamError'); hasError = true; }
    if (!pembayaran) { showFieldError('pembayaran', 'pembayaranError'); hasError = true; }

    if (hasError) { showToast('Lengkapi semua data pemesanan', 'error'); return; }

    const hotel = hotels.find(h => h.id === hotelId);
    const total = hotel.harga * kamar * malam;

    pendingOrder = { nama, hotel: hotel.nama, lokasi: hotel.lokasi, kamar, malam, total, pembayaran, hargaPerMalam: hotel.harga, userEmail: user.email };

    // Lanjut ke Detail Booking & Konfirmasi
    generateBookingDetail();
}

function showFieldError(inputId, errorId) {
    document.getElementById(inputId).classList.add('error');
    document.getElementById(errorId).classList.add('visible');
}

function clearErrors() {
    document.querySelectorAll('.form-group input, .form-group select').forEach(el => el.classList.remove('error'));
    document.querySelectorAll('.field-error').forEach(el => el.classList.remove('visible'));
}


/* ========================================
   6. KONFIRMASI PESANAN
   ======================================== */
function closeModal() {
    document.getElementById('modalOverlay').classList.remove('visible');
}


/* ========================================
   7. DETAIL BOOKING
   ======================================== */
function generateBookingDetail() {
    const hotel = hotels.find(h => h.nama === pendingOrder.hotel);
    const detail = document.getElementById('modalDetail');
    
    detail.innerHTML = `
        <div class="row"><span class="lbl">Nama</span><span class="val">${pendingOrder.nama}</span></div>
        <div class="row"><span class="lbl">Hotel</span><span class="val">${pendingOrder.hotel}</span></div>
        <div class="row"><span class="lbl">Lokasi</span><span class="val">${pendingOrder.lokasi}</span></div>
        <div class="row"><span class="lbl">Harga / malam</span><span class="val">Rp ${pendingOrder.hargaPerMalam.toLocaleString('id-ID')}</span></div>
        <div class="row"><span class="lbl">Jumlah kamar</span><span class="val">${pendingOrder.kamar}</span></div>
        <div class="row"><span class="lbl">Lama menginap</span><span class="val">${pendingOrder.malam} malam</span></div>
        <div class="row"><span class="lbl">Pembayaran</span><span class="val">${pendingOrder.pembayaran}</span></div>
        <div class="row total"><span class="lbl" style="font-weight:600;">Total</span><span class="val">Rp ${pendingOrder.total.toLocaleString('id-ID')}</span></div>
    `;
    
    // Tampilkan modal konfirmasi
    document.getElementById('modalOverlay').classList.add('visible');
}

function konfirmasiPesan() {
    closeModal();

    const bookings = getBookings();

    // Generate kode booking unik
    const kode = 'BK-' + Date.now().toString(36).toUpperCase() + Math.random().toString(36).substring(2, 5).toUpperCase();

    const newBooking = {
        id: Date.now(),
        kode: kode,
        nama: pendingOrder.nama,
        hotel: pendingOrder.hotel,
        lokasi: pendingOrder.lokasi,
        kamar: pendingOrder.kamar,
        malam: pendingOrder.malam,
        hargaPerMalam: pendingOrder.hargaPerMalam,
        total: pendingOrder.total,
        pembayaran: pendingOrder.pembayaran,
        status: 'Menunggu',
        tanggal: new Date().toLocaleDateString('id-ID', { day: 'numeric', month: 'long', year: 'numeric', hour: '2-digit', minute: '2-digit' }),
        userEmail: pendingOrder.userEmail
    };

    bookings.push(newBooking);
    saveBookings(bookings);

    showToast(`Pemesanan berhasil! Kode: ${kode}`, 'success');

    // WhatsApp redirect (Kontak)
    const msg = `Halo, saya ingin melakukan reservasi hotel:%0ANama: ${newBooking.nama}%0AHotel: ${newBooking.hotel}%0AJumlah Kamar: 
    ${newBooking.kamar}%0ALama Menginap: ${newBooking.malam} malam%0AMetode Pembayaran: ${newBooking.pembayaran}%0ATotal: 
    Rp ${newBooking.total.toLocaleString('id-ID')}%0AKode Booking: ${newBooking.kode}`;

    setTimeout(() => {
        window.open(`https://wa.me/6281234567890?text=${msg}`, '_blank');
    }, 1500);

    // Reset form
    setTimeout(() => {
        document.getElementById('nama').value = '';
        document.getElementById('nama').classList.remove('has-value');
        document.getElementById('hotel').value = '';
        document.getElementById('kamar').value = '';
        document.getElementById('malam').value = '';
        document.getElementById('pembayaran').value = '';
        document.getElementById('totalHarga').textContent = 'Rp 0';
        document.getElementById('totalHarga').dataset.current = '0';
        document.getElementById('hotelInfo').classList.remove('visible');
        document.getElementById('mapOverlay').innerHTML = '<i class="fas fa-info-circle"></i> Pilih hotel untuk melihat lokasi';

        // Isi ulang nama dari user
        const user = getCurrentUser();
        if (user) {
            document.getElementById('nama').value = user.name;
            document.getElementById('nama').classList.add('has-value');
        }
    }, 1600);
}

/* ========================================
   8. KONTAK
   ======================================== */

/* ========== INISIALISASI & EVENT LISTENERS ========== */
document.addEventListener('DOMContentLoaded', function() {
    
    // Init Navbar Auth
    updateNavAuth();

    // Init Dropdown Hotel
    initHotelDropdown();

    // Init Parallax Home
    initParallaxHero();

    // Event Listener Floating Label (Login/Register)
    document.querySelectorAll('.input-group input').forEach(input => {
        input.addEventListener('input', () => {
            input.classList.toggle('has-value', input.value.length > 0);
        });
        input.addEventListener('blur', () => {
            input.classList.toggle('has-value', input.value.length > 0);
        });
    });

    // Event Listener Hapus Error Form Pemesanan
    document.querySelectorAll('.form-group input, .form-group select').forEach(el => {
        el.addEventListener('input', () => {
            el.classList.remove('error');
            const errEl = el.parentElement.querySelector('.field-error');
            if (errEl) errEl.classList.remove('visible');
        });
        el.addEventListener('change', () => {
            el.classList.remove('error');
            const errEl = el.parentElement.querySelector('.field-error');
            if (errEl) errEl.classList.remove('visible');
        });
    });

    // Event Listener Close Modal Klik Diluar Box
    document.getElementById('modalOverlay').addEventListener('click', function(e) {
        if (e.target === this) closeModal();
    });

});