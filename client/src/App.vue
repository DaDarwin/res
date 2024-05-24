<script setup>
import { AppState } from "./AppState";
import Navbar from "./components/Navbar.vue";
</script>

<template>
	<header>
		<Navbar />
	</header>

	<main class="container-fluid">
		<router-view />
	</main>

	<footer class="bg-dark text-light p-3">
		<div class="w-50">
			<a href="https://github.com/DaDarwin">
				<i class="mdi mdi-linkedin"></i>
			</a>
			<a href="https://www.linkedin.com/in/darien-jensen/">
				<i class="mdi mdi-github"></i
			></a>
		</div>
		<span class="w-50"> </span>
	</footer>
</template>

<style lang="scss">
@import "./assets/scss/main.scss";

:root {
	--main-height: calc(100vh - 32px - 64px);
}

footer {
	display: grid;
	place-content: center;
	height: 32px;
}
</style>
