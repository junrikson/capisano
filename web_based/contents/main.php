
<!--==============================content================================-->
    <section id="content"><div class="ic"></div>
        <div class="main">
            <div class="wrapper img-indent-bot">
                <article class="col-1">
                	<a href="#"><img class="img-border" src="images/banner-1.jpg" alt=""></a>
                </article>
                <article class="col-1">
                	<a href="#"><img class="img-border" src="images/banner-2.jpg" alt=""></a>
                </article>
                <article class="col-2">
                	<a href="#"><img class="img-border" src="images/banner-3.jpg" alt=""></a>
                </article>
            </div>
            <div class="wrapper">
            	<article class="column-1">
                	<div class="indent-left">
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
                        <h6 class="p2">Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.</h6>
                        <p class="p2">Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi.</p>
                        Nam liber tempor cum soluta nobis eleifend option congue nihil imperdiet doming id quod mazim placerat facer possim assum. Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem. Investigationes demonstraverunt lectores legere me lius quod ii legunt saepius. 
                    </div>
                    <a class="button-2" href="#">Read More</a>
                </article>
            </div>
        </div>
    </section>
   