async function downloadCv() {
    const fileName = 'Leonardo-Ganas-CV.pdf';
    const fileUrl = 'Leonardo_Ganas_CV.pdf';

    try {
        const response = await fetch(fileUrl);
        if (!response.ok) throw new Error('Network response was not ok');
        
        const blob = await response.blob();
        const url = window.URL.createObjectURL(blob);
        const link = document.createElement('a');
        
        link.href = url;
        link.setAttribute('download', fileName);
        
        // Hide link and append to body
        link.style.display = 'none';
        document.body.appendChild(link);
        
        // Trigger download
        link.click();
        
        // Cleanup after a short delay
        setTimeout(() => {
            document.body.removeChild(link);
            window.URL.revokeObjectURL(url);
        }, 100);
        
    } catch (error) {
        console.error('Download failed:', error);
        // Fallback to simple window.open if fetch fails
        window.location.href = fileUrl;
    }
}