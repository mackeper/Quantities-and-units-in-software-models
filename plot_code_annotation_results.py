import matplotlib
import matplotlib.pyplot as plt
import numpy as np
import pprint

# Settings:
degrees = 30
width = 0.1  # the width of the bars

# DATA DomainModels
labels   = ['Avg MI' , 'Sum SLOC', 'Avg CC', 'Max CC', 'Sum CC', 'DIT' , 'Sum coupling', 'Avg LOC per member']#, 'Avg LOC per type']
q_means  = [90.720   , 1138356   , 1.349   , 119     , 180044  , 75    , 354949        , 8.526               ]#, 141.897           ]
un_means = [90.721   , 1138229   , 1.348   , 119     , 180025  , 75    , 354939        , 8.526               ]#, 141.916           ]
d_means  = [90.721   , 1138229   , 1.348   , 119     , 180019  , 75    , 354818        , 8.526               ]#, 141.917           ]

# DATA Framework
#labels   = ['Avg MI' , 'Sum SLOC', 'Avg CC', 'Max CC', 'Sum CC', 'DIT' , 'Sum coupling', 'Avg LOC per member', 'Avg LOC per type']
#q_means  = [89.928   , 310430    , 1.19    , 83      , 66856   , 51    , 136952        , 5.53                , 137.884           ]
#un_means = [89.105   , 265413    , 1.264   , 83      , 38167   , 51    , 95012         , 8.787               , 127.143           ]
#d_means  = [89.105   , 265403    , 1.264   , 83      , 38165   , 51    , 95010         , 8.787               , 127.139           ]

m = [labels, q_means, un_means, d_means]

rows = 2
cols = 4
fig, axs = plt.subplots(nrows=rows, ncols=cols)
axs = axs.flatten()
for i in range(len(axs)):
    label = labels[i]
    data = [[q_means[i]], [un_means[i]], [d_means[i]]]
    x = np.arange(1)  # the label locations

    rects1 = axs[i].bar(x - width*1.1, data[0], width, label='Quantities')
    rects2 = axs[i].bar(x            , data[1], width, label='UnitsNet'  )
    rects3 = axs[i].bar(x + width*1.1, data[2], width, label='Without'   )

    axs[i].set_xlabel(label)
    axs[i].set_xticks([])
    axs[i].set_yscale("log")
    axs[i].legend()
    plt.setp(axs[i].xaxis.get_majorticklabels(), rotation=degrees)

    def autolabel(rects):
        """Attach a text label above each bar in *rects*, displaying its height."""
        for rect in rects:
            height = rect.get_height()
            axs[i].annotate('{}'.format(height),
                        xy=(rect.get_x() + rect.get_width()/2, height),
                        xytext=(0, 3),  # 3 points vertical offset
                        textcoords="offset points",
                        ha='center', va='bottom')

    autolabel(rects1)
    autolabel(rects2)
    autolabel(rects3)

plt.show()