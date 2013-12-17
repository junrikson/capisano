
<!--==============================content================================-->
    <section id="content"><div class="ic"></div>
        <div class="main">
            <div class="wrapper img-indent-bot">
                <article class="col-1">
                	<a href="#"><img class="img-border" src="images/banner-1.jpg" alt=""></a>
                </article>
                <article class="col-2">
                	<a href="#"><img class="img-border" src="images/banner-2.jpg" alt=""></a>
                </article>
                <article class="col-3">
                	<a href="#"><img class="img-border" src="images/banner-3.jpg" alt=""></a>
            </div>
						<article class="col-1">
                	<a href="#"><img class="img-border" src="images/banner-4.jpg" alt=""></a>
                </article>
                <article class="col-2">
                	<a href="#"><img class="img-border" src="images/banner-5.jpg" alt=""></a>
                </article>
                <article class="col-3">
                	<a href="#"><img class="img-border" src="images/banner-6.jpg" alt=""></a>
            </div>
            <div class="wrapper">
            	<article class="column-2">
                	<div class="indent-right">
						<div class="maxheight indent-bot">
                
                        
                        <?php
						if(!cek()){
							echo '
                            <form action="login.php?action=login" method="post">
                            <h3 class="p1">Login Form</h3>                       							
							<div><input type="text" placeholder="Email / HP" required id="username" name="username"/></div><br/>
							<div><input type="password" placeholder="Password" required id="password" name="password"/></div><br/>						
							<input type="submit" value="Log in" />
							<a href="index.php?menu=Forgot">Lupa password?</a>
							<a href="index.php?menu=Register">Daftar</a>
							</form>';
						}
						else{
							echo '<h3 class="p1">Selamat Datang '.$_SESSION['username'].'</h3> 
							<h3 class="p1"><a href="login.php?action=logout">Logout</a></h3>';							
						}
						?>
                        </div>
                        <a class="button-1" href="#">Read More</a>
                    </div>
                </article>
                <article class="column-2">
                	<div class="maxheight indent-bot">
                        <h3 class="p1">About the Catering</h3>
                        <h6 class="p2">Catering ini adalah Catering terbaik yang menyajikan sajian-sajian  yang akan memanjakan Lidah anda setaip harinya. Semua masakan yang di sediakan di Catering kami dibuat oleh Chef-Chef berpengalaman..</h6>
                        <p class="p2">Visi Misi Kami adalah menyajikan masakan-masakan Internasional dengan Harga yang bersahabat sehingga dapat dinikmati setiap harinya tampa harus menguras dompet dari pelanggan pelanggan setia kami.<cite>Tiap Rasa yang anda Rasakan adalah tanggung jawab kami yang memuaskannya.</cite></p>
                       <p class="p2"> Alamat dari Usaha Catering ini dapat anda kunjungi pada pada Jalan.Thamrin No.432 (Sebelah bang BII cabang Thamrin) atau telp: 061-7896767 ,061-7658989 Fax:061-7942178 Medan,Sumatera Utara</p>
					   <h3> Lihat Komentar Para Pelanggan Setia Kami</h3>
                    <a class="button-2" href="https://twitter.com/CapisanoNo1">Twitter</a>
                </article>
            </div>
        </div>
    </section>
   
