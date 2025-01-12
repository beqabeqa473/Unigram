﻿using Unigram.Collections;
using Unigram.Services;
using Unigram.ViewModels.Gallery;

namespace Unigram.ViewModels
{
    public class SingleGalleryViewModel : GalleryViewModelBase
    {
        public SingleGalleryViewModel(IProtoService protoService, IStorageService storageService, IEventAggregator aggregator, GalleryContent item)
            : base(protoService, storageService, aggregator)
        {
            Items = new MvxObservableCollection<GalleryContent> { item };
            SelectedItem = item;
            FirstItem = item;
        }
    }
}
